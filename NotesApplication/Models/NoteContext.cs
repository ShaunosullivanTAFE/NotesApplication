using Microsoft.EntityFrameworkCore;

namespace NotesApplication.Models
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Note> Notes { get; set; }
        public DbSet<Author> Authors { get; set; }


    }
}
