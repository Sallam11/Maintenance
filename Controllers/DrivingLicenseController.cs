using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class DrivingLicenseController : Controller
    {
        // GET: DrivingLicenseController

        MaintenanceDbContext _db;
        public DrivingLicenseController(MaintenanceDbContext context)
        {
            _db = context;
        }
        public ActionResult Index()
        {
            var _var = _db.DrivingLicenses.ToList();
            return View(_var);
        }

        // GET: DrivingLicenseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DrivingLicenseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DrivingLicenseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DrivingLicense collection)
        {
            try
            {
                _db.DrivingLicenses.Add(collection);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DrivingLicenseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DrivingLicenseController/Edit/5
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

        // GET: DrivingLicenseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DrivingLicenseController/Delete/5
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
