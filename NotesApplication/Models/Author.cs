using System.Collections.Generic;

namespace NotesApplication.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // One Author has Many Notes
        public ICollection<Note> Notes { get; set; }
    }

}
