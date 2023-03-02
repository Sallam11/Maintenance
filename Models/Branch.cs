using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Maintenance.Models
{
    public class Branch
    {
        [Key]

        [DisplayName("Code")]
        public int Branch_ID { get; set; }

        [DisplayName("Branch ar Name")]
        public string Branch_ArName { get; set; } = string.Empty;


        [DisplayName("Branch Eng Name")]
        public string Branch_EngName { get; set; } = string.Empty;
    }
}
