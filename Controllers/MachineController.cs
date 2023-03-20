using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Maintenance.Data;
using Maintenance.Models;


namespace Maintenance.Controllers
{
    public class MachineController : Controller
    {
        // GET: MachineController
        private readonly MaintenanceDbContext _db;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment hosting;

        public MachineController(MaintenanceDbContext context , Microsoft.AspNetCore.Hosting.IHostingEnvironment hosting)
        {
            _db = context;
            this.hosting = hosting;
        }

        public ActionResult Index()
        {
          var _Var = _db.Machines.Include(s => s.PlaceOfWorks).Include(s => s.Owners).Include(s => s.Machine_SubGroups).Include(x => x.Machine_Groups).Include(s => s.Brands).Include(x => x.Models).ToList();
            return View(_Var);
        }
    

        // GET: MachineController/Details/5
        public ActionResult Details(int id)
        {
            var  _Var = _db.Machines.Include(s => s.PlaceOfWorks).Include(s => s.Owners).Include(s => s.Machine_SubGroups).Include(x => x.Machine_Groups).Include(s => s.Brands).Include(x => x.Models).FirstOrDefault(x => x.Machine_ID == id);
            return View(_Var);
        }

        // GET: MachineController/Create
        public ActionResult Create()
        {
            //ViewBag.Groups = _db.Machine_Groups.ToList();
            //ViewBag.SubGroups = _db.Machine_SubGroups.ToList();
            //ViewBag.Brands = _db.Brands.ToList();
            //ViewBag.Models = _db.Models.ToList();
            //ViewBag.Owners = _db.Owners.ToList();
            //ViewBag.PlaceOfWorks = _db.PlaceOfWorks.ToList();

            var model = new Machine
            {
                Machine_Groups = Machine_Group_FillSelectList(),
                Machine_SubGroups = Machine_SubGroup_FillSelectList(),
                Brands = Brand_FillSelectList(),
                Models = Model_FillSelectList(),
                Owners = Owner_FillSelectList(),
                PlaceOfWorks = PlaceOfWork_FillSelectList()
            };








            return View();
           
        }

        // POST: MachineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Machine collection)
        {


            try
            {
                if (ModelState.IsValid)
                {
                    collection.Machine_ImageURL = UploadFile(collection.File) ?? string.Empty;
                }
                _db.Machines.Add(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            
        }

        // GET: MachineController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Groups = _db.Machine_Groups.ToList();
            ViewBag.SubGroups = _db.Machine_SubGroups.ToList();
            ViewBag.Brands = _db.Brands.ToList();
            ViewBag.Models = _db.Models.ToList();
            ViewBag.Owners = _db.Owners.ToList();
            ViewBag.PlaceOfWorks = _db.PlaceOfWorks.ToList();
            var _var = _db.Machines.FirstOrDefault(x => x.Machine_ID == id);
            return View(_var);
        }

        // POST: MachineController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Machine collection)
        {
            try
            {
                collection.Machine_ID = id;
                _db.Machines.Update(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MachineController/Delete/5
        public ActionResult Delete(int id)
        {
            var _Var = _db.Machines.Include(s => s.PlaceOfWorks).Include(s => s.Owners).Include(s => s.Machine_SubGroups).Include(x => x.Machine_Groups).Include(s => s.Brands).Include(x => x.Models).FirstOrDefault(x => x.Machine_ID == id);
            return View(_Var);
        }

        // POST: MachineController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Machine collection)
        {
            try
            {
                collection.Machine_ID = id;
                _db.Machines.Remove(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "uploads");
                string fullPath = Path.Combine(uploads, file.FileName);
                file.CopyTo(new FileStream(fullPath, FileMode.Create));

                return file.FileName;
            }

            return null;
        }

        string UploadFile(IFormFile file, string imageUrl)
        {
            if (file != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "uploads");

                string newPath = Path.Combine(uploads, file.FileName);
                string oldPath = Path.Combine(uploads, imageUrl);

                if (oldPath != newPath)
                {
                    System.IO.File.Delete(oldPath);
                    file.CopyTo(new FileStream(newPath, FileMode.Create));
                }

                return file.FileName;
            }

            return imageUrl;
        }



        List<Owner> Owner_FillSelectList()
        {
            var Owners = _db.Owners.ToList();
            Owners.Insert(0, new Owner { Owner_ID = -1, Owner_Name = "--- Please select an Owners ---" });

            return Owners;
        }
        List<Machine_Group> Machine_Group_FillSelectList()
        {
            var Machine_Group = _db.Machine_Groups.ToList();
            Machine_Group.Insert(0, new Machine_Group { MachineGroup_ID = -1, MachineGroup_Name = "--- Please select an Machine Group ---" });

            return Machine_Group;
        }
        List<Machine_SubGroup> Machine_SubGroup_FillSelectList()
        {
            var Machine_SubGroup = _db.Machine_SubGroups.ToList();
            Machine_SubGroup.Insert(0, new Machine_SubGroup { MachineSubgroup_ID = -1, MachineSubgroup_Name = "--- Please select an Machine Sub Group ---" });

            return Machine_SubGroup;
        }

        List<Brand> Brand_FillSelectList()
        {
            var Brand = _db.Brands.ToList();
            Brand.Insert(0, new Brand { Brand_ID = -1, Brand_Name = "--- Please select an Brand ---" });

            return Brand;
        }

        List<Model> Model_FillSelectList()
        {
            var Model = _db.Models.ToList();
            Model.Insert(0, new Model { Model_ID = -1, Model_Name = "--- Please select an Model ---" });

            return Model;
        }

        List<PlaceOfWork> PlaceOfWork_FillSelectList()
        {
            var PlaceOfWork = _db.PlaceOfWorks.ToList();
            PlaceOfWork.Insert(0, new PlaceOfWork { PlaceOfWork_ID = -1, PlaceOfWork_Name = "--- Please select an Place Of Work ---" });
            return PlaceOfWork;
        }
    }
}
