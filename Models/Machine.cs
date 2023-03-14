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
        public string Machine_Code { get; set; } = string.Empty;
    

        [DisplayName("Machine")]
        public int GroupID_FK { get; set; }
        [DisplayName("Machines Type")]
        public int SubGroupID_FK { get; set; }
        [DisplayName("Brand")]
        public int BrandID_FK { get; set; }
        [DisplayName("Model")]
        public int ModelID_FK { get; set; }
        [DisplayName("Owner")]
        public int OwnerID_FK { get; set; }

        [DisplayName("Plate No.")]
        [StringLength(20)]
        public string Machine_PlateNo { get; set; } = string.Empty;
        [DisplayName("Manufacturer Year")]
        [NotMapped]
        public System.Data.SqlTypes.SqlDateTime Machine_ManufacturerYear { get; set; }
        [StringLength(20)]
        [DisplayName("Serial No.")]
        public string Machine_SerialNo { get; set; } = string.Empty;
        [DisplayName("Note")]
        public string Machine_Note { get; set; } = string.Empty;
        [DisplayName("Image")]
        public string Machine_ImageURL { get; set; } = string.Empty;

        [NotMapped]
        public IFormFile? File { get; set; }


        [ForeignKey(nameof(GroupID_FK))]
        public Machine_Group? Machine_Groups { get; set; }

        [ForeignKey(nameof(SubGroupID_FK))]
        public Machine_SubGroup? Machine_SubGroups { get; set; }

        [ForeignKey(nameof(BrandID_FK))]
        public Brand? Brands { get; set; }

        [ForeignKey(nameof(ModelID_FK))]
        public Model? Models { get; set; }


        [ForeignKey(nameof(OwnerID_FK))]
        public Owner? Owners { get; set; }





    }
}
