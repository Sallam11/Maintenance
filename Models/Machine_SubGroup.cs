using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Maintenance.Models
{
    public class Machine_SubGroup
    {

        [Key]
        [DisplayName("Code")]
        public int MachineSubgroup_ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [DisplayName("Type Machine")]
        public string MachineSubgroup_Name { get; set; } = string.Empty;
        [DisplayName("Group Machine")]
        public int MachineGroupIDFK { get; set; }

        [ForeignKey(nameof(MachineGroupIDFK))]
        public Machine_Group? Machine_Groups { get; set; }
    }
}
