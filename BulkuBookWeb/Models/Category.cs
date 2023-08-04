using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkuBookWeb.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        [DisplayName("Display Order")]
        //[Range(1, 100, ErrorMessage = "Display order number range must be within 1 to 100")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
