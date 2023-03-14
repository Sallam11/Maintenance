using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maintenance.Models
{
    public class Employee
    {
        [Key]
        [DisplayName("Code")]
        public int  Employee_ID { get; set; }

        [StringLength(10)]
        [DisplayName("No")]
        [Required]
        public string Employee_No { get; set; } = string.Empty;


        [StringLength(150)]
        [DisplayName("English Name")]
        [Required]
        public string Employee_EngName { get; set; } = string.Empty;


        [StringLength(200)]
        [DisplayName("Arabic Name")]
        [Required]
        public string Employee_ArName { get; set; } = string.Empty;

        [StringLength(20)]
        [DisplayName("Phone")]
        public string Employee_Phone { get; set; } = string.Empty;

        [StringLength(20)]
        [DisplayName("Iqama No.")]
        [Required]
        public string Employee_Iqama { get; set; } = string.Empty;

        public string Employee_ImageURL { get; set; } = string.Empty;

        public int  BranchID_FK { get; set; }
        public int ProfessionID_FK { get; set; }
        public int DrivingLicenseID_FK { get; set; }
        public int PlaceOfWorkID_FK { get; set; }
    



        [ForeignKey(nameof(BranchID_FK))]
        public Branch? Branchs { get; set; }


        [ForeignKey(nameof(ProfessionID_FK))]
        public Profession? Professions { get; set; }

        [ForeignKey(nameof(DrivingLicenseID_FK))]
        public DrivingLicense? DrivingLicenses { get; set; }


        [ForeignKey(nameof(PlaceOfWorkID_FK))]
        public PlaceOfWork? PlaceOfWorks { get; set; }




        [NotMapped]
        public IFormFile? File { get; set; }

    }
}
