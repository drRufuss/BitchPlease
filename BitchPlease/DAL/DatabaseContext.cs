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
        public DbSet<Language> Language { get; set; }
        public DbSet<Language> Group { get; set; }
        public DbSet<UserGroup> UserGroup { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Models.User.ModelCreating(modelBuilder);
            Models.Group.ModelCreating(modelBuilder);
            Models.UserGroup.ModelCreating(modelBuilder);
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
            : base(options)
        {
        }

        public DbSet<BitchPlease.Models.Group> Group_1 { get; set; }
    }
}
