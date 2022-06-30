using System;
using System.ComponentModel.DataAnnotations;

namespace ElevenNote.BlazorWASM.Shared.Models
{
    public class NoteEdit
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public int CategoryId { get; set; }
    }
}

