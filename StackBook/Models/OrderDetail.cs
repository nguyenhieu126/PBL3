using System.ComponentModel.DataAnnotations;

namespace StackBook.Models
{
    public class OrderDetail
    {
        [Key]
        public Guid OrderDetailId { get; set; } = Guid.NewGuid();

        [Required]
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }

        [Required]
        public Guid BookId { get; set; } 
        public virtual Book Book { get; set; }

        [Required]
        public int quantity { get; set; }


        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public double price { get; set; }
    }
}
