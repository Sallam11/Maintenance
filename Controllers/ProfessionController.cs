using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class ProfessionController : Controller
    {
        // GET: ProfessionController

        MaintenanceDbContext _db;
        public ProfessionController(MaintenanceDbContext context)
        {
            _db = context;
        }
        public ActionResult Index()
        {
            var _var = _db.Professions.ToList();
            return View(_var);
        }

        // GET: ProfessionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProfessionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfessionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Profession collection)
        {
            try
            {
                _db.Professions.Add(collection);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfessionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProfessionController/Edit/5
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

        // GET: ProfessionController/Delete/5
        public ActionResult Delete(int id)
        {
            var _var = _db.Professions.FirstOrDefault(x => x.Profession_ID == id);
            return View(_var);
        }

        // POST: ProfessionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Profession collection)
        {
            try
            {
                collection.Profession_ID = id;
                _db.Professions.Remove(collection);
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
