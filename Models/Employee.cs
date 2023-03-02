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

        public int Employee_BranchID { get; set; }

        public int Employee_ProfessionID { get; set; }
        [ForeignKey(nameof(Employee_ProfessionID))]
        public Profession? Professions { get; set; }
        [ForeignKey(nameof(Employee_BranchID))]
        public Branch? Branchs { get; set; }

        [StringLength(200)]
        [DisplayName("Iqama No.")]
        [Required]
        public string Employee_iqama { get; set; } = string.Empty;
        [NotMapped]
        public IFormFile File { get; set; }



    }
}
