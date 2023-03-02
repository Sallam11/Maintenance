using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Maintenance.Models
{
	public class Login
	{
		[Required]
		//[EmailAddress]
		public string UserName { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Display(Name = "Remember me?")]
		public bool RememberMe { get; set; }
	}
}
