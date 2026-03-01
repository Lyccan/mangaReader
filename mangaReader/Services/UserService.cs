using mangaReader.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace mangaReader.Services
{
    public class UserService
    {

        private readonly IMongoCollection<User> _users;

        public UserService(MongoDbContext context)
        {
            _usersCollection = context.GetCollection<User>("users");
        }

        public CreateUser(User user) { 
        
            await _users.InsertOneAsync(user);
        }
    }
}
