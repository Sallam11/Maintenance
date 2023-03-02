using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maintenance.Models
{
    public class Brand_SubGroup
    {
        [Key]
        [DisplayName("Code")]
        public int BarndSubgroup_ID { get; set; }
        [Required]
        [StringLength(50,MinimumLength =2)]
        [DisplayName("Sub Group Name")]
        public string BarndSubgroup_Name { get; set; } = string.Empty;
        [DisplayName("Group Name")]
        public int BarndGroup_IDFK { get; set; } 

        [ForeignKey(nameof(BarndGroup_IDFK))]
        public Brand_Group? Brand_Groups { get; set; }

    }
}
