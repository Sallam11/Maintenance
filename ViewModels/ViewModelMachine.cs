using Maintenance.Models;

namespace Maintenance.ViewModels
{
    public class ViewModelMachine
    {
        public List<Owner> Owners { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Model> Models { get; set; }

        public List<PlaceOfWork> PlaceOfWorks { get; set; }

        public List<Machine_SubGroup> Machine_SubGroups { get; set; }
        public List<Machine_Group> Machine_Groups { get; set; }
    }
}
