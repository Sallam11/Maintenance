using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maintenance.Models
{
    
    public class Brand
    {
        [Key]
        [DisplayName("Code")]
        public int Barnd_ID { get; set; }
        [StringLength(50)]
        [DisplayName("Name")]
        [Required]
        public string Barnd_Name { get; set; } = string.Empty;


        public int MachineSubgroup_IDFK { get; set; }

        [ForeignKey(nameof(MachineSubgroup_IDFK))]
        public Machine_SubGroup? Machine_SubGroup { get; set; }

    }
}