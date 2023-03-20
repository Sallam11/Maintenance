using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class PlaceOfWorkController : Controller
    {
        // GET: PlaceOfWorkController

        MaintenanceDbContext _db;
        public PlaceOfWorkController(MaintenanceDbContext context)
        {
            _db = context;
        }
        public ActionResult Index()
        {
            var _var = _db.PlaceOfWorks.ToList();
            return View(_var);
        }

        // GET: PlaceOfWorkController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlaceOfWorkController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlaceOfWorkController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlaceOfWork collection)
        {
            try
            {
                _db.PlaceOfWorks.Add(collection);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlaceOfWorkController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlaceOfWorkController/Edit/5
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

        // GET: PlaceOfWorkController/Delete/5
        public ActionResult Delete(int id)
        {
            var _var = _db.PlaceOfWorks.FirstOrDefault(x => x.PlaceOfWork_ID == id);
            return View(_var);
        }

        // POST: PlaceOfWorkController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, PlaceOfWork collection)
        {
            try
            {
                collection.PlaceOfWork_ID = id;
                _db.PlaceOfWorks.Remove(collection);
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
