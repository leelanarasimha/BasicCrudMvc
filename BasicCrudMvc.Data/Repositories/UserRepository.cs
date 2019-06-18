using System;
using System.Collections.Generic;
using System.Text;
using BasicCrudMvc.core.Contracts;
using BasicCrudMvc.core.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicCrudMvc.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private BasicCrudMvcDbContext db;

        public UserRepository(BasicCrudMvcDbContext dbcontext)
        {
            db = dbcontext;
        }
        public IEnumerable<User> getAllUsers()
        {
            return db.Users;
        }
        
    }
}
