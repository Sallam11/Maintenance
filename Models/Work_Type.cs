using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Maintenance.Models
{
    public class Work_Type
    {
        [Key]
        [DisplayName("Code")]
        public int WorkType_ID { get; set; }
        [StringLength(20)]
        [DisplayName("Name")]
        [Required]
        public string WorkType_Name { get; set; } = string.Empty;

    }
}
