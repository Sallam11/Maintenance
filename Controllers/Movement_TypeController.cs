using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class Movement_TypeController : Controller
    {
        // GET: Movement_TypeController
        private readonly MaintenanceDbContext _db;

        public Movement_TypeController(MaintenanceDbContext context)
        {
            _db = context;
        }

        public ActionResult Index()
        {
            var _var = _db.Movement_Types.ToList();
            return View(_var);
        }

        // GET: Movement_TypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movement_TypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movement_TypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movement_Type collection)
        {
            try
            {
                var _var = _db.Movement_Types.Add(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Movement_TypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movement_TypeController/Edit/5
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

        // GET: Movement_TypeController/Delete/5
        public ActionResult Delete(int id)
        {

            var _var = _db.Movement_Types.FirstOrDefault(x => x.MovementType_ID == id);
            return View(_var);
        }

        // POST: Movement_TypeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Movement_Type collection)
        {
            try
            {
                collection.MovementType_ID = id;
                _db.Movement_Types.Remove(collection);
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
