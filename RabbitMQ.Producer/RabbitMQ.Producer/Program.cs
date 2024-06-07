using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Producer
{
    static class Program
    {
        static void Main(string[] args)
        {
            string uriString = "amqp://guest:guest@localhost:5672/";

            // Convert URI string to System.Uri object
            Uri uri = new Uri(uriString);

            // Create connection factory and set URI
            var factory = new ConnectionFactory()
            {
                Uri = uri
            };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare("demo-queue",
                durable:true,
                exclusive:false,
                autoDelete:false,
                arguments:null);
            var messege = new { Name = "Procedure", Messege = "Hello!" };
            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(messege));

            channel.BasicPublish("", "demo-queue", null, body);
        }
    }
}
