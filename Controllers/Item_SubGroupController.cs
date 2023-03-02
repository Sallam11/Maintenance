using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class Item_SubGroupController : Controller

    {

        private readonly MaintenanceDbContext _db;

        public Item_SubGroupController(MaintenanceDbContext context)
        {
            _db = context;
        }

        // GET: Item_SubGroupController
        public ActionResult Index()
        {
            var _Var = _db.Item_SubGroups.Include(s => s.Item_Groups).ToList();
            return View(_Var);
        }

        // GET: Item_SubGroupController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Item_SubGroupController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item_SubGroupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Item_SubGroup collection)
        {
            try
            {
                var _var = _db.Item_SubGroups.Add(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Item_SubGroupController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Item_SubGroupController/Edit/5
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

        // GET: Item_SubGroupController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Item_SubGroupController/Delete/5
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
