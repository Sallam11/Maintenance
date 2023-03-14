using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Maintenance.Models
{
    public class OrdersStatus
    {
        [Key]
        [DisplayName("Code")]
        public int OrdersStatus_ID { get; set; }
        [StringLength(20)]
        [DisplayName("Name")]
        [Required]
        public string OrdersStatus_Name { get; set; } = string.Empty;

    }
}
