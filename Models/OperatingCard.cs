using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Maintenance.Models
{
    public class OperatingCard
    {
        [Key]
        [DisplayName("Code")]
        public int OperatingCard_ID { get; set; }
        [StringLength(50)]
        [Display(Name = "Name")]
        public string OperatingCard_ArName { get; set; } = string.Empty;
    
      
    }
}
