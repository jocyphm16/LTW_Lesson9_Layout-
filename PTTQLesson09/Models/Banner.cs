using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PTTQLesson09.Models
{
    [Table("Banner")]
    [Index(nameof(Name), IsUnique = true)]
    public class Banner
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên banner không được rỗng")]
        [StringLength(100)]
        public string Name { get; set; }

        public byte Status { get; set; } = 1;

        public int Prioty { get; set; } = 0; // Tên cột viết theo đúng tài liệu mẫu, mặc định 0

        [StringLength(100)]
        public string? Image { get; set; }

        [StringLength(350)]
        public string? Description { get; set; }
    }
}