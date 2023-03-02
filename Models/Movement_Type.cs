using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Maintenance.Models
{
    public class Movement_Type
    {
        [Key]
        [DisplayName("Code")]
        public int MovementType_ID { get; set; }
        [StringLength(50)]
        [DisplayName("Name")]
        [Required]
        public string MovementType_Name { get; set; } = string.Empty;
    }
}
