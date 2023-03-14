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
        [DisplayName("Sub Group Name")]
        public string MachineSubgroup_Name { get; set; } = string.Empty;
        [DisplayName("Group Name")]
        public int MachineGroup_IDFK { get; set; }

        [ForeignKey(nameof(MachineGroup_IDFK))]
        public Machine_Group? Brand_Groups { get; set; }
    }
}
