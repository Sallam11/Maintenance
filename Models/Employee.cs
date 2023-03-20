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
        [DisplayName("Eng. Name")]
        [Required]
        public string Employee_EngName { get; set; } = string.Empty;


        [StringLength(200)]
        [DisplayName("Ar.Name")]
        [Required]
        public string Employee_ArName { get; set; } = string.Empty;

        [StringLength(20)]
        [DisplayName("Phone")]
        public string Employee_Phone { get; set; } = string.Empty;

        [StringLength(20)]
        [DisplayName("Iqama")]
        [Required]
        public string Employee_Iqama { get; set; } = string.Empty;

        public string Employee_ImageURL { get; set; } = string.Empty;
        [DisplayName("Branch")]
        public int  BranchIDFK { get; set; }
        [DisplayName("Profession")]
        public int ProfessionIDFK { get; set; }
        [DisplayName("License")]
        public int DrivingLicenseIDFK { get; set; }
        [DisplayName("Place Of Work")]
        public int PlaceOfWorkIDFK { get; set; }
    



        [ForeignKey(nameof(BranchIDFK))]
        public Branch? Branchs { get; set; }


        [ForeignKey(nameof(ProfessionIDFK))]
        public Profession? Professions { get; set; }

        [ForeignKey(nameof(DrivingLicenseIDFK))]
        public DrivingLicense? DrivingLicenses { get; set; }


        [ForeignKey(nameof(PlaceOfWorkIDFK))]
        public PlaceOfWork? PlaceOfWorks { get; set; }




        [NotMapped]
        public IFormFile? File { get; set; }

    }
}
