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
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Language Language { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public int? FacebookId { get; set; }
        public bool Admin { get; set; }
        public bool Blocked { get; set; }
        [Column(TypeName = "smallint")]
        public int Gender { get; set; }
        public int Verified { get; set; }

        public ICollection<Group> CreatedGroups { get; set; }
        public ICollection<Group> UpdatedGroups { get; set; }
    }
}
