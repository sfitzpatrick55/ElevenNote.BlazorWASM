using System;
using System.ComponentModel.DataAnnotations;

namespace ElevenNote.BlazorWASM.Server.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

