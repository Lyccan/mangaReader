using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace mangaReader.Data
{
    public class MongoDbContext
    {

        private readonly IMongoDatabase _database;
        public MongoDbContext()
        {

            DotNetEnv.Env.TraversePath().Load();
            string connectionString = Environment.GetEnvironmentVariable("MONGO_CONNECTION_STRING");

            if (connectionString != null)
            {
                MongoClient client = new MongoClient(connectionString);
                _database = client.GetDatabase("mangaReader");
            }
            else
            {
                throw new Exception("MongoDB connection string is not set in environment variables.");

            }
            
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _database.GetCollection<T>(name);
        }
    }
}
