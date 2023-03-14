using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand_GroupController
        private readonly MaintenanceDbContext _db;

        public BrandController(MaintenanceDbContext context)
        {
            _db = context;
        }

        public ActionResult Index()
        {
            var _var = _db.Brands.ToList();
            return View(_var);
        }

        // GET: Brand_GroupController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Brand_GroupController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Brand_GroupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Brand collection)
        {
            try
            {
                var _var = _db.Brands.Add(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Brand_GroupController/Edit/5
        public ActionResult Edit(int id)
        {
            var _var = _db.Brands.FirstOrDefault(x => x.Barnd_ID ==id);
            return View(_var);
        }

        // POST: Brand_GroupController/Edit/5
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

        // GET: Brand_GroupController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Brand_GroupController/Delete/5
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
