using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Consumer
{
    static class Program
    {
        public static void Main(string[] args)
        {
            /*var factory = new ConnectionFactory
               {
                   Uri = new Uri("amqp://user:pass@hostName:port/vhost")
               };*/

            ConnectionFactory factory = new ConnectionFactory();
            var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare("demo-queue",
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, e) =>
            {
                var body = e.Body.ToArray();
                var messege = Encoding.UTF8.GetString(body);
                Console.WriteLine("Received"+messege);
            };
            channel.BasicConsume("demo-queue",true,consumer);
            Console.ReadLine();
        }
    }
}
