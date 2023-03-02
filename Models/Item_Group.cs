using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Maintenance.Models
{
    public class Item_Group
    {
        [Key]
        [DisplayName("Code")]
        public int ItemGroup_ID { get; set; }
        [Required]
        [DisplayName("Item Group Name")]
        [StringLength(50)]
        public string ItemGroup_Name { get; set; } = string.Empty;
    }
}
