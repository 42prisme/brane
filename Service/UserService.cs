using System;
using System.Collections.Generic;
using System.Linq;
using brane.Models;
using Microsoft.Extensions.Logging;
// using MySql.Data.MySqlClient;

namespace brane.Service
{
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly MyDbContext _context;
        public UserService(MyDbContext context, ILogger<UserService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public User GetOne(int id)
        {
            return _context.Users.Find(id);
        }

        public List<User> GetIn()
        {
            throw new System.NotImplementedException();
        }

        public List<User> GetAll(int i)
        {
            return _context.Users.ToList();
        }

        public void Add(User item)
        {
            _logger.Log(LogLevel.Information, "add new user");
            _context.Users.Add(item);
            _context.SaveChanges();
        }

        public void Edit(User item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }

        public void Delete(User item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }
    }
}