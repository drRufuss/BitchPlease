using System;
using System.Text.Json.Serialization;

namespace BitchPlease.Models
{
    public class Group
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public long CreatedBy { get; set; }
        [JsonIgnore]
        public virtual User CreatedByUser { get; set; }
        public long UpdatedBy { get; set; }
        [JsonIgnore]
        public virtual User UpdatedByUser { get; set; }
        public bool Active { get; set; }
    }
}
