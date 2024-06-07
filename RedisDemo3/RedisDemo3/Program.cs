using System;
using StackExchange.Redis;

namespace RedisCRUDExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
            IDatabase db = redis.GetDatabase();

            db.StringSet("key", "value");

            string value = db.StringGet("key");
            Console.WriteLine("Value: " + value);

            db.StringSet("key", "new_value");

            value = db.StringGet("key");
            Console.WriteLine("Updated Value: " + value);

            db.KeyDelete("key");

            value = db.StringGet("key");
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Key deleted successfully.");
            }
            else
            {
                Console.WriteLine("Failed to delete key.");
            }
            Console.ReadKey();
        }
    }
}
