using System;
namespace ElevenNote.BlazorWASM.Shared.Models
{
    public class NoteListItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CategoryName { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}

