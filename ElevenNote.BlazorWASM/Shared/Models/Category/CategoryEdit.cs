using System;
using System.ComponentModel.DataAnnotations;

namespace ElevenNote.BlazorWASM.Shared.Models.Category
{
    public class CategoryEdit
    {
        [Required]
        public string Name { get; set; }
    }
}

