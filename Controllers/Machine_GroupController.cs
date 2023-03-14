using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class Machine_GroupController : Controller
    {
        // GET: Machine_GroupController
        private readonly MaintenanceDbContext _db;

        public Machine_GroupController(MaintenanceDbContext context)
        {
            _db = context;
        }

        public ActionResult Index()
        {
            var _var = _db.Machine_Groups.ToList();
            return View(_var);
        }

        // GET: Machine_GroupController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Machine_GroupController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Machine_GroupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Machine_Group collection)
        {
            try
            {
                var _var = _db.Machine_Groups.Add(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Machine_GroupController/Edit/5
        public ActionResult Edit(int id)
        {
            var _var = _db.Machine_Groups.FirstOrDefault(x => x.MachineGroup_ID ==id);
            return View(_var);
        }

        // POST: Machine_GroupController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: Machine_GroupController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Machine_GroupController/Delete/5
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
