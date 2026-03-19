using Microsoft.AspNetCore.Connections;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

namespace ShipmentService
{
    public class RabbitWorker : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };

            var connection = await factory.CreateConnectionAsync();
            var channel = await connection.CreateChannelAsync();

            // Read from payment queue
            await channel.QueueDeclareAsync(
                queue: "payment_queue",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            Console.WriteLine("ShipmentService waiting for payment confirmation...");

            var consumer = new AsyncEventingBasicConsumer(channel);

            consumer.ReceivedAsync += async (sender, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);

                var paymentResult = JsonSerializer.Deserialize<PaymentResult>(message);

                if (paymentResult == null)
                {
                    Console.WriteLine("Invalid payment message");
                    return;
                }

                Console.WriteLine($"Payment received for Order: {paymentResult.OrderId}");

                // 🚚 Shipment Logic
                Console.WriteLine("Shipment Started...");
                await Task.Delay(2000); // simulate delay
                Console.WriteLine("Shipment Completed ✅");

                var shipmentMessage = new
                {
                    OrderId = paymentResult.OrderId,
                    Status = "SHIPPED"
                };

                var shipmentBody = Encoding.UTF8.GetBytes(
                    JsonSerializer.Serialize(shipmentMessage));

                // Optional next queue
                await channel.QueueDeclareAsync(
                    queue: "shipment_queue",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

                await channel.BasicPublishAsync(
                    exchange: "",
                    routingKey: "shipment_queue",
                    body: shipmentBody);

                await Task.CompletedTask;
            };

            await channel.BasicConsumeAsync(
                queue: "payment_queue",
                autoAck: true,
                consumer: consumer);
        }
    }
}