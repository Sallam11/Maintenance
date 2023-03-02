using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class Item_GroupController : Controller
    {
        // GET: Item_GroupController
        private readonly MaintenanceDbContext _db;

        public Item_GroupController(MaintenanceDbContext context)
        {
            _db = context;
        }
        public ActionResult Index()
        {
            var _var = _db.Item_Groups.ToList();
            return View(_var);
        }

        // GET: Item_GroupController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Item_GroupController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item_GroupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Item_Group collection)
        {
            try
            {
                var _var = _db.Item_Groups.Add(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Item_GroupController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Item_GroupController/Edit/5
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

        // GET: Item_GroupController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Item_GroupController/Delete/5
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
