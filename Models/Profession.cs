using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Maintenance.Models
{
    public class Profession
    {
        [Key]
        [DisplayName("Code")]
        public int Profession_ID { get; set; }
        [StringLength(50)]
        [Display(Name = "Ar Name")]
        public string Profession_ArName { get; set; } = string.Empty;
        [Display(Name = "Eng Name")]
        [StringLength(50)]
        public string Profession_EngName { get; set; } = string.Empty;
    }
}
