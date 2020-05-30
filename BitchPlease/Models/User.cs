using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BitchPlease.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int LanguageId { get; set; }
        [JsonIgnore]
        public virtual Language Language { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public int? FacebookId { get; set; }
        public bool Admin { get; set; }
        public bool Blocked { get; set; }
        [Column(TypeName = "smallint")]
        public int Gender { get; set; }
        public int Verified { get; set; }

        [JsonIgnore]
        public virtual ICollection<Group> CreatedGroups { get; set; }
        [JsonIgnore]
        public virtual ICollection<Group> UpdatedGroups { get; set; }
    }
}
