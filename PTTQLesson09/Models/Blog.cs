using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PTTQLesson09.Models
{
    [Table("Blog")]
    [Index(nameof(Name), IsUnique = true)]
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên blog không được rỗng")]
        [StringLength(100)]
        public string Name { get; set; }

        public byte Status { get; set; } = 1;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [StringLength(100)]
        public string? Image { get; set; }

        [StringLength(350)]
        public string? Description { get; set; }
    }
}