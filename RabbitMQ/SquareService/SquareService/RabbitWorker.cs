using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;
using SquareService.Model;
namespace PaymentService
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

            // Read from order queue
            await channel.QueueDeclareAsync(
                queue: "order_queue",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            Console.WriteLine("PaymentService waiting for orders...");

            var consumer = new AsyncEventingBasicConsumer(channel);

            consumer.ReceivedAsync += async (sender, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);

                var order = JsonSerializer.Deserialize<Order>(message);

                // 💡 Payment Logic
                Console.WriteLine($"Processing Payment for Order {order.OrderId}");
                Console.WriteLine($"Product: {order.Product}, Amount: {order.Amount}");

                string paymentStatus = "SUCCESS"; // you can simulate failure also

                var result = new
                {
                    order.OrderId,
                    Status = paymentStatus
                };

                var responseBody = Encoding.UTF8.GetBytes(
                    JsonSerializer.Serialize(result));

                // Send to payment queue (optional response queue)
                await channel.QueueDeclareAsync(
                    queue: "payment_queue",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

                await channel.BasicPublishAsync(
                    exchange: "",
                    routingKey: "payment_queue",
                    body: responseBody);

                await Task.CompletedTask;
            };

            await channel.BasicConsumeAsync(
                queue: "order_queue",
                autoAck: true,
                consumer: consumer);
        }
    }
}