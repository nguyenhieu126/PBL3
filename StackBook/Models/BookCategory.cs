using System.ComponentModel.DataAnnotations;

namespace StackBook.Models
{
    public class BookCategory
    {
        //[Key]
        //public int Id { get; set; }
        public Guid BookId { get; set; }
        public virtual Book Book { get; set; }

        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
