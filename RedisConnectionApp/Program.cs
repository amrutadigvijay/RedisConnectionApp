
using System;
using StackExchange.Redis;

namespace RedisConnectionApp
{
    internal class Program
    {
        private const string RedisConnectionString = "localhost"; // Connection string for local Redis server
        private static void Main(string[] args)
        {
            // Create a connection to the Redis server
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(RedisConnectionString);
            IDatabase db = redis.GetDatabase(); // Get the database instance

            // Example operation: Set and get a value
            db.StringSet("Gender", "Female"); // Set a key-value pair
            //string value = db.StringGet("Gender"); // Retrieve the value associated with the key

            Console.WriteLine(db.StringGet("Gender")); // Output the retrieved value
            Console.ReadLine();
        }
    }
} 