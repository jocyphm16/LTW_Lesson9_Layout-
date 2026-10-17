using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PTTQLesson09.Models
{
    [Table("Category")]
    [Index(nameof(Name), IsUnique = true)] // Ràng buộc không trùng
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được rỗng")]
        [StringLength(100)]
        public string Name { get; set; }

        public byte Status { get; set; } = 1; // Kiểu Tinyint, mặc định là 1

        public DateTime CreatedDate { get; set; } = DateTime.Now; // Mặc định ngày hiện tại

        // Khai báo mối quan hệ 1-N với Product
        public ICollection<Product>? Products { get; set; }
    }
}