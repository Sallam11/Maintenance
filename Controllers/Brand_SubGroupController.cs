using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class Brand_SubGroupController : Controller
    {
        // GET: Brand_SubGroupController
        private readonly MaintenanceDbContext _db;

        public Brand_SubGroupController(MaintenanceDbContext context)
        {
            _db = context;
        }

        public ActionResult Index()
        {
          

            var _Var = _db.Brand_SubGroups.Include(s => s.Brand_Groups).ToList();



            return View(_Var);
        }

        // GET: Brand_SubGroupController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Brand_SubGroupController/Create
        public ActionResult Create()
        {
            ViewBag.Brand_Groups = _db.Brand_Groups.ToList();
            return View();
        }

        // POST: Brand_SubGroupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Brand_SubGroup collection)
        {
            try
            {
                var _var = _db.Brand_SubGroups.Add(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Brand_SubGroupController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Brand_SubGroupController/Edit/5
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

        // GET: Brand_SubGroupController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Brand_SubGroupController/Delete/5
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
