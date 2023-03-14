using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class Machine_SubGroupController : Controller
    {
        // GET: Machine_SubGroupController
        private readonly MaintenanceDbContext _db;

        public Machine_SubGroupController(MaintenanceDbContext context)
        {
            _db = context;
        }

        public ActionResult Index()
        {
          

            //var _Var = _db.Machine_SubGroups.Include(s => s.Machine_Groups).ToList();



            return View();
        }

        // GET: Machine_SubGroupController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Machine_SubGroupController/Create
        public ActionResult Create()
        {
            ViewBag.Machine_Groups = _db.Machine_Groups.ToList();
            return View();
        }

        // POST: Machine_SubGroupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Machine_SubGroup collection)
        {
            try
            {
                var _var = _db.Machine_SubGroups.Add(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Machine_SubGroupController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Machine_SubGroupController/Edit/5
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

        // GET: Machine_SubGroupController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Machine_SubGroupController/Delete/5
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
