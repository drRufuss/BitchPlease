using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public int FacebookId { get; set; }        
        public bool IsAdmin { get; set; }
        public bool IsBlocked { get; set; }
        [Column(TypeName = "smallint")]
        public int Gender { get; set; }
        public int IsVerified { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
