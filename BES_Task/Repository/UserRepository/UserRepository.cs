using BES_Task.Data.Context;
using BES_Task.Data.Models;
using System;

namespace BES_Task.Repository.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _context;

        public UserRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public User GetUserByUsername(string username)
        {
            return _context.Users.SingleOrDefault(u => u.Username == username);
        }
    }
}
