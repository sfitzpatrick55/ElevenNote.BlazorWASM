using System;
using System.ComponentModel.DataAnnotations;

namespace ElevenNote.BlazorWASM.Shared.Models.Category
{
    public class CategoryCreate
    {
        [Required]
        public string Name { get; set; }
    }
}

