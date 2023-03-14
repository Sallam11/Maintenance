using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Maintenance.Models
{
    public class PlaceOfWork
    {
        [Key]

        [DisplayName("Code")]
        public int PlaceOfWork_ID { get; set; }
        [StringLength(50)]
        [DisplayName("Place Name")]
        public string PlaceOfWork_Name { get; set; } = string.Empty;


      
    }
}
