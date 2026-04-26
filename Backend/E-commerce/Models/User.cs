using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(100)]
        public string Password { get; set; }
        [Required, StringLength(100)]
        public string Email { get; set; }
        public string FullName { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>(); // trong các mốt quan hệ một nhiều
                                                                                    // thì cần tạo ICollection để nhận biết
    }
}
