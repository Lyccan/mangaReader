using mangaReader.Data;
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
            _users = context.GetCollection<User>("users");
        }

        public async System.Threading.Tasks.Task CreateUser(User user)
        {
            _users.InsertOneAsync(user);
        }


    }
}
