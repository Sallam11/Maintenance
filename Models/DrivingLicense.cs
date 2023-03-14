using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maintenance.Models
{
    
    public class DrivingLicense
    {
        [Key]
        [DisplayName("Code")]
        public int DrivingLicense_ID { get; set; }
        [StringLength(50)]
        [DisplayName("Name")]
        [Required]
        public string DrivingLicense_Name { get; set; } = string.Empty;


       

    }
}