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
        public int GroupIDFK { get; set; }
        [DisplayName("Machines Type")]
        public int SubGroupIDFK { get; set; }
        [DisplayName("Brand")]
        public int BrandIDFK { get; set; }
        [DisplayName("Model")]
        public int ModelIDFK { get; set; }
        [DisplayName("Owner")]
        public int OwnerIDFK { get; set; }
        [DisplayName("Place Of Work")]
        public int PlaceOfWorkIDFK { get; set; }

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


        //[ForeignKey(nameof(GroupIDFK))]
        //public Machine_Group? Machine_Groups { get; set; }

        //[ForeignKey(nameof(SubGroupIDFK))]
        //public Machine_SubGroup? Machine_SubGroups { get; set; }

        //[ForeignKey(nameof(BrandIDFK))]
        //public Brand? Brands { get; set; }

        //[ForeignKey(nameof(ModelIDFK))]
        //public Model? Models { get; set; }


        //[ForeignKey(nameof(OwnerIDFK))]
        //public Owner? Owners { get; set; }


        //[ForeignKey(nameof(PlaceOfWorkIDFK))]
        //public PlaceOfWork? PlaceOfWorks { get; set; }


        public List<Owner> Owners { get; set; } = new List<Owner>();
        public List<Brand> Brands { get; set; } = new List<Brand>();
        public List<Model> Models { get; set; } = new List<Model>();

        public List<PlaceOfWork> PlaceOfWorks { get; set; } = new List<PlaceOfWork>();

        public List<Machine_SubGroup> Machine_SubGroups { get; set; } = new List<Machine_SubGroup>();
        public List<Machine_Group> Machine_Groups { get; set; } = new List<Machine_Group>();



    }
}
