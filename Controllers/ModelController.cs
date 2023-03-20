using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class ModelController : Controller
    {
        // GET: Brand_SubGroupController
        private readonly MaintenanceDbContext _db;

        public ModelController(MaintenanceDbContext context)
        {
            _db = context;
        }

        public ActionResult Index()
        {
           var _Var = _db.Models.Include(s => s.Brands).ToList();
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
            ViewBag.Barnds =_db.Brands.ToList();

            return View();
        }

        // POST: Brand_SubGroupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Model collection)
        {
            try
            {
                var _var = _db.Models.Add(collection);
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
            var _Var = _db.Models.Include(s => s.Brands).FirstOrDefault(I => I.Model_ID == id);
            return View(_Var);
        }

        // POST: Brand_SubGroupController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Model collection)
        {
            try
            {
                collection.Model_ID = id;
                _db.Models.Remove(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
