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
            modelBuilder.Entity<User>()
                .Property(b => b.CreateDate)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<User>()
                .Property(b => b.IsAdmin)
                .HasDefaultValue(false);

            modelBuilder.Entity<User>()
                .Property(b => b.IsBlocked)
                .HasDefaultValue(false);

            modelBuilder.Entity<User>()
                .Property(b => b.IsVerified)
                .HasDefaultValue(false);
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
            : base(options)
        {
        }
    }
}
