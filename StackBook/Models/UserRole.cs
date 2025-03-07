using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace StackBook.Models
{
    public class UserRole
    {
        [Key]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        public string RoleName { get; set; }

    }
}
