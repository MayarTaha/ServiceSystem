﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceSystem.Models;
using ServiveceSystem.Models;

namespace ServiveceSystem.BusinessLayer
{
    public class UserService
    {
        private readonly AppDBContext _context;

        public UserService(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<User>>getAll()
        {
            return await _context.Users.Where(e=>!e.isDeleted).ToListAsync();
        }
        public async Task<User> GetById(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task AddUser(User user)
        {
            var exists = await _context.Users.AnyAsync(s => s.Username.ToLower() == user.Username.ToLower() && !s.isDeleted);

            if (!exists)
            {
                 user.CreatedLog = DateTime.Now.ToString();
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateUser(User user)
        {
            var exists = await _context.Users.AnyAsync(s => s.Username.ToLower() == user.Username.ToLower() && !s.isDeleted);

            if (!exists)
               { 
                user.UpdatedLog = DateTime.Now.ToString();
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                user.isDeleted = true;
                user.DeletedLog = DateTime.Now.ToString();
                await _context.SaveChangesAsync();
            }
        }
    }
}
