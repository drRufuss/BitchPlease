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
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public long CreatedBy { get; set; }
        public User CreatedByUser { get; set; }
        public long UpdatedBy { get; set; }
        public User UpdatedByUser { get; set; }
        public bool Active { get; set; }
    }
}
