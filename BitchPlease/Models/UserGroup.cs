using System;
using System.Text.Json.Serialization;

namespace BitchPlease.Models
{
    public class UserGroup
    {
        public long UserId { get; set; }
        [JsonIgnore]
        public virtual User User { get; set; }
        public long GroupId { get; set; }
        [JsonIgnore]
        public virtual Group Group { get; set; }
        public bool Admin { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
