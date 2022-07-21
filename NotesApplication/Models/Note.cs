using System;

namespace NotesApplication.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
       
        // One note has one author
        public Author Author { get; set; }
        // FK
        public int AuthorId { get; set; }

    }

}
