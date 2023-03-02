using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Maintenance.Models
{
    
    public class Brand_Group
    {
        [Key]
        [DisplayName("Code")]
        public int BarndGroup_ID { get; set; }
        [StringLength(50)]
        [DisplayName("Name")]
        [Required]
        public string BarndGroup_Name { get; set; } = string.Empty;

    }
}