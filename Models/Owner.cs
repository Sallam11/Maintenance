using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Maintenance.Models
{
    public class Owner
    {
        [Key]
        [DisplayName("Code")]
        public int Owner_ID { get; set; }
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Owner_Name { get; set; } = string.Empty;
       
    }
}
