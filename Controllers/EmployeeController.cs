using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Maintenance.Data;
using Maintenance.Models;
using Microsoft.EntityFrameworkCore;

namespace Maintenance.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        private readonly MaintenanceDbContext _db;

        public EmployeeController(MaintenanceDbContext context)
        {
            _db = context;
        }

        public ActionResult Index()
        {
            var _var = _db.Employees.Include(a =>a.Branchs).Include(a => a.Professions).Include(a => a.DrivingLicenses).Include(a => a.PlaceOfWorks).ToList();

            return View(_var);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var _var = _db.Employees.Include(a => a.Branchs).Include(a => a.Professions).Include(a => a.DrivingLicenses).Include(a => a.PlaceOfWorks).FirstOrDefault(I => I.Employee_ID == id);
            return View(_var);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            ViewBag.Branchs = _db.Branchs.ToList();
            ViewBag.Professions = _db.Professions.ToList();
            ViewBag.DrivingLicenses = _db.DrivingLicenses.ToList();
            ViewBag.PlaceOfWorks = _db.PlaceOfWorks.ToList();
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee collection)
        {
            try
            {
                _db.Employees.Add(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Branchs = _db.Branchs.ToList();
            ViewBag.Professions = _db.Professions.ToList();
            ViewBag.DrivingLicenses = _db.DrivingLicenses.ToList();
            ViewBag.PlaceOfWorks = _db.PlaceOfWorks.ToList();
            var _var = _db.Employees.FirstOrDefault(I => I.Employee_ID == id);
            return View(_var);
          
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee collection)
        {
            try
            {
                collection.Employee_ID = id;
                _db.Employees.Update(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var _var = _db.Employees.Include(a => a.Branchs).Include(a => a.Professions).Include(a => a.DrivingLicenses).Include(a => a.PlaceOfWorks).FirstOrDefault(I => I.Employee_ID == id);
            return View(_var);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee collection)
        {
            try
            {
                 collection.Employee_ID = id;
                _db.Employees.Remove(collection);
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
