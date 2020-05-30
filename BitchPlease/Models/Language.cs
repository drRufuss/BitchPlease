using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BitchPlease.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<User> Users { get; set; }
    }
}
