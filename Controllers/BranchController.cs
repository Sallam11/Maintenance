using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class BranchController : Controller
    {
        // GET: BranchController

        MaintenanceDbContext _db;
        public BranchController(MaintenanceDbContext context)
        {
            _db = context;
        }
        public ActionResult Index()
        {
            var _var = _db.Branchs.ToList();
            return View(_var);
        }

        // GET: BranchController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BranchController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BranchController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Branch collection)
        {
            try
            {
                _db.Branchs.Add(collection);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BranchController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BranchController/Edit/5
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

        // GET: BranchController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BranchController/Delete/5
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
