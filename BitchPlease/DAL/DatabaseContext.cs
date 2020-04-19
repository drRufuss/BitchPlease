using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BitchPlease.Models;

namespace BitchPlease.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
            : base(options)
        {
        }
    }
}
