using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maintenance.Models
{
    public class Item_SubGroup
    {
        [Key]
        [DisplayName("Code")]
        public int ItemSubGroup_ID { get; set; }

        [Required]
        [DisplayName("Item Group")]
        public int ItemGroup_IDFK { get; set; }
        [DisplayName("Item SubGroup")]

        [Required]
        [StringLength(50)]
        public string ItemSubGroup_Name { get; set; } = string.Empty;

        [ForeignKey(nameof(ItemGroup_IDFK))]
        public Item_Group? Item_Groups { get; set; }
    }
}
