using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Maintenance.Models
{
    public class Machine_Group
    {
        [Key]
        [DisplayName("Code")]
        public int MachineGroup_ID { get; set; }
        [StringLength(50)]
        [DisplayName("Name")]
        [Required]
        public string MachineGroup_Name { get; set; } = string.Empty;
    }
}
