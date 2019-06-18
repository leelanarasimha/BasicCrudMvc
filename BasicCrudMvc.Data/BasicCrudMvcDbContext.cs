using System;
using System.Collections.Generic;
using System.Text;
using BasicCrudMvc.core.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicCrudMvc.Data
{
    public class BasicCrudMvcDbContext : DbContext
    {
        public BasicCrudMvcDbContext(DbContextOptions<BasicCrudMvcDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
