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

        public MachineController(MaintenanceDbContext context)
        {
            _db = context;
        }

        public ActionResult Index()
        {
            var _Var = _db.Machines.Include(s => s.Brand_Group).Include(x => x.Brand_SubGroup).ToList();
            return View(_Var);
        }
    

        // GET: MachineController/Details/5
        public ActionResult Details(int id)
        {
            var _var = _db.Machines.FirstOrDefault(x => x.Machine_ID == id);
            return View(_var);
        }

        // GET: MachineController/Create
        public ActionResult Create()
        {

            ViewBag.Brand_Groups = _db.Brand_Groups.ToList();
            ViewBag.Brand_SubGroups = _db.Brand_SubGroups.ToList();
            return View();
           
        }

        // POST: MachineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Machine collection)
        {
            try
            {
                var _var = _db.Machines.Add(collection);
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
            ViewBag.Brand_Groups = _db.Brand_Groups.ToList();
            ViewBag.Brand_SubGroups = _db.Brand_SubGroups.ToList();
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
            return View();
        }

        // POST: MachineController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
