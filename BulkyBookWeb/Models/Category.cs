using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Required(ErrorMessage = "Please Enter Display Order Number")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 to 100!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
