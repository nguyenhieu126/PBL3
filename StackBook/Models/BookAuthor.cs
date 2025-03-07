using System.ComponentModel.DataAnnotations;

namespace StackBook.Models
{
    public class BookAuthor
    {
        //[Key]
        //public int Id { get; set; }
        public Guid BookId { get; set; }
        public virtual Book Book { get; set; }

        public Guid AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
