using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Maintenance.Data;
using Maintenance.Models;
using Microsoft.EntityFrameworkCore;

namespace Maintenance.Controllers
{
    public class BrandController : Controller
    {
        // GET: BrandController

        MaintenanceDbContext _db;
        public BrandController(MaintenanceDbContext context)
        {
            _db = context;
        }
        public ActionResult Index()
        {
            var _var = _db.Brands.Include(x => x.Machine_Groups).Include(i => i.Machine_SubGroups).ToList();
            return View(_var);
        }

        // GET: BrandController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BrandController/Create
        public ActionResult Create()
        {
            ViewBag.MachineGroups = _db.Machine_Groups.ToList();
            ViewBag.MachineSubGroups = _db.Machine_SubGroups.ToList();
            return View();
        }

        // POST: BrandController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Brand collection)
        {
            try
            {
                _db.Brands.Add(collection);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BrandController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BrandController/Edit/5
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

        // GET: BrandController/Delete/5
        public ActionResult Delete(int id)
        {
            var _var = _db.Brands.Include(x => x.Machine_Groups).Include(i => i.Machine_SubGroups).FirstOrDefault(x => x.Brand_ID == id);
           
            return View(_var);
          
        }

        // POST: BrandController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Brand collection)
        {
            try
            {

                collection.Brand_ID = id;
                _db.Brands.Remove(collection);
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
