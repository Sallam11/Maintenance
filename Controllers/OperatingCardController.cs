using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class OperatingCardController : Controller
    {
        // GET: OperatingCardController

        MaintenanceDbContext _db;
        public OperatingCardController(MaintenanceDbContext context)
        {
            _db = context;
        }
        public ActionResult Index()
        {
            var _var = _db.OperatingCards.ToList();
            return View(_var);
        }

        // GET: OperatingCardController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OperatingCardController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OperatingCardController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OperatingCard collection)
        {
            try
            {
                _db.OperatingCards.Add(collection);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OperatingCardController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OperatingCardController/Edit/5
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

        // GET: OperatingCardController/Delete/5
        public ActionResult Delete(int id)
        {

            var _var = _db.OperatingCards.FirstOrDefault(x => x.OperatingCard_ID == id);
            return View(_var);
        }

        // POST: OperatingCardController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, OperatingCard collection)
        {
            try
            {
                collection.OperatingCard_ID = id;
                _db.OperatingCards.Remove(collection);
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
