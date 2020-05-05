using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitchPlease.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
