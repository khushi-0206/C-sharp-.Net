using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using RabbitMQDemo.Model;
using System.Text;
using System.Text.Json;

namespace ProducerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        public async Task<string> CreateOrder([FromBody] Order order)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };

            await using var connection = await factory.CreateConnectionAsync();
            await using var channel = await connection.CreateChannelAsync();

            // Queue for Order Service → Payment Service
            await channel.QueueDeclareAsync(
                queue: "order_queue",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            var message = JsonSerializer.Serialize(order);
            var body = Encoding.UTF8.GetBytes(message);

            await channel.BasicPublishAsync(
                exchange: "",
                routingKey: "order_queue",
                body: body);

            return "Order Created & Sent for Payment!";
        }
    }
}