using System.ComponentModel.DataAnnotations;

namespace StackBook.Models
{
    public class ReturnOrder
    {
        [Key]
        public Guid ReturnOrderId { get; set; } = Guid.NewGuid();
        [Required]
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
        [Required]
        public Guid ShippingAddressId { get; set; }
        public virtual ShippingAddress ShippingAddress { get; set; }
        [Required]
        public string reason { get; set; }
        [Required]
        public DateTime CreatedReturn { get; set; }
    }
}
