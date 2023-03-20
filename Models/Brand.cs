using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Maintenance.Models
{
    public class Brand
    {
        [Key]

        [DisplayName("Code")]
        public int Brand_ID { get; set; }
        [StringLength(50)]
        [DisplayName("Name")]
        public string Brand_Name { get; set; } = string.Empty;
        [DisplayName("Machine")]
        public int MachineGroupIDFK { get; set; }
        [DisplayName("Machine Type")]
        public int MachineSubGroupIDFK { get; set; }
        [ForeignKey(nameof(MachineGroupIDFK))]
        public Machine_Group? Machine_Groups { get; set; }
        [ForeignKey(nameof(MachineSubGroupIDFK))]
        public Machine_SubGroup? Machine_SubGroups { get; set; }
    }
}