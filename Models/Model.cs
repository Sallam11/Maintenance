using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maintenance.Models
{
    public class Model
    {
        [Key]
        [DisplayName("Code")]
        public int Model_ID { get; set; }
        [Required]
        [StringLength(50,MinimumLength =2)]
        [DisplayName("Sub Group Name")]
        public string Model_Name { get; set; } = string.Empty;
        [DisplayName("Group Name")]
        public int Barnd_IDFK { get; set; } 

        [ForeignKey(nameof(Barnd_IDFK))]
        public Brand? Brand_Groups { get; set; }

    }
}
