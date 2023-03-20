
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maintenance.Models
{
    public class Model
    {
        [Key]
        [DisplayName("Code")]
        public int Model_ID { get; set; }
        [Required]
        [StringLength(50,MinimumLength =2)]
        [DisplayName("Model")]
        public string Model_Name { get; set; } = string.Empty;
        [DisplayName("Brand")]
        public int BarndIDFK { get; set; }

        [ForeignKey(nameof(BarndIDFK))]
        public Brand? Brands { get; set; }


    }
}
