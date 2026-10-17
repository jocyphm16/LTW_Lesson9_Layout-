using Microsoft.EntityFrameworkCore;
using PTTQLesson09.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTTQLesson09.Models
{
    [Table("Product")]
    [Index(nameof(Name), IsUnique = true)]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được rỗng")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Giá không được rỗng")]
        public double Price { get; set; }

        public double SalePrice { get; set; } = 0; // Mặc định là 0

        public byte Status { get; set; } = 1; // Mặc định là 1

        [Required(ErrorMessage = "Vui lòng chọn danh mục")]
        public int CategoryId { get; set; } // Khóa ngoại liên kết Category

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [StringLength(100)]
        public string? Image { get; set; } // Dấu ? thể hiện cho phép rỗng

        [StringLength(350)]
        public string? Description { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
    }
}