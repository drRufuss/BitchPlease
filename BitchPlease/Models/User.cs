using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BitchPlease.Models
{
    public class User
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int LanguageId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public int FacebookId { get; set; }
        public bool Admin { get; set; }
        public bool Blocked { get; set; }
        [Column(TypeName = "smallint")]
        public int Gender { get; set; }
        public int Verified { get; set; }

        public Language Language { get; set; }
        public IList<UserGroup> UserGroups { get; set; }

        public static void ModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(b => b.CreateDate)
                .HasDefaultValueSql("NOW()");

            modelBuilder.Entity<User>()
                .Property(b => b.Admin)
                .HasDefaultValue(false);

            modelBuilder.Entity<User>()
                .Property(b => b.Blocked)
                .HasDefaultValue(false);

            modelBuilder.Entity<User>()
                .Property(b => b.Verified)
                .HasDefaultValue(false);
        }
    }
}
