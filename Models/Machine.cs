using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maintenance.Models
{
    public class Machine
    {
        [Key]
        [DisplayName("Code")]
        public int Machine_ID { get; set; }
        [StringLength(20)]
        [DisplayName("No")]
        [Required]
        public string Machine_No { get; set; } = string.Empty;
        public string Machine_PhotoPath { get; set; } = string.Empty;
        [DisplayName("Name")]
        public string Machine_Name { get; set; } = string.Empty;

        [DisplayName("Group Name")]
        public int GroupID_FK { get; set; }
        [DisplayName("Sub Group Name")]
        public int SubGroupID_FK { get; set; }
        [ForeignKey(nameof(GroupID_FK))]
        public Brand_Group? Brand_Group { get; set; }

        [ForeignKey(nameof(SubGroupID_FK))]
        public Brand_SubGroup? Brand_SubGroup { get; set; }
        [NotMapped]
        public IFormFile file { get; set; }


    }
}
