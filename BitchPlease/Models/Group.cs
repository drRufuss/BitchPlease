using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BitchPlease.Models
{
    public class Group
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        [Required]
        [ForeignKey("User")]
        public long CreatedBy { get; set; }
        [ForeignKey("User")]
        public long UpdatedBy { get; set; }
        public bool Active { get; set; }


        [ForeignKey("CreatedBy")]
        public User UserCreatedBy { get; set; }
        [ForeignKey("UpdatedBy")]
        public User UserUpdatedBy { get; set; }
        public IList<UserGroup> UserGroups { get; set; }
    }
}
