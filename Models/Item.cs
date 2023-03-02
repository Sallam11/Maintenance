
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maintenance.Models
{
    public class Item
    {
        [Key]
        [DisplayName("Code")]
        public int Item_ID { get; set; }
        [DisplayName("Item Name")]
        [Required]
        [StringLength(150)]
        public string Item_Name { get; set; } = string.Empty;

        [DisplayName("Item Group")]
        [Required]
        public int ItemGroup_IDFK { get; set; }
        [Required]
        [DisplayName("Item Sub Group")]
        public int ItemSubGroup_IDFK { get; set; }
        [Required]
        [StringLength(30)]
        [DisplayName("Item Code No.")]
        public string Item_Code { get; set; } = string.Empty;
     
        [ForeignKey(nameof(ItemGroup_IDFK))]
        public Item_Group? Item_Groups { get; set; }
        [ForeignKey(nameof(ItemSubGroup_IDFK))]
        public Item_SubGroup? Item_SubGroups { get; set; }
    }
}
