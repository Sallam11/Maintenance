using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Maintenance.Models
{
   
    public class User
    {
        [Key]
        [DisplayName("Code")]
        public int User_ID { get; set; }
        [StringLength(20)]
        [DisplayName("User Name")]
        public string User_Name { get; set; } = string.Empty;
       
        [StringLength(20)]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string User_Password { get; set; } = string.Empty;
        [DisplayName("Active")]
        public bool User_Active { get; set; }

		[DisplayName("Employee")]
        [Required]
        public int EmployeeID_FK { get; set; }
        [ForeignKey(nameof(EmployeeID_FK))]
		public Employee? Employees { get; set; }

	}
}