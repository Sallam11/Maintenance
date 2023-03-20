using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class ItemController : Controller
    {
        // GET: ItemController


        private readonly MaintenanceDbContext _db;

        public ItemController(MaintenanceDbContext context)
        {
            _db = context;
        }
        public ActionResult Index()
        {
            var _Var = _db.Items.Include(s => s.Item_Groups).Include(s => s.Item_SubGroups).ToList();
            return View(_Var);
        }

        // GET: ItemController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemController/Create
        public ActionResult Create()
        {
            ViewBag.ItemGroups = _db.Item_Groups.ToList();
            ViewBag.ItemSubGroups = _db.Item_SubGroups.ToList();
            return View();
        }

        // POST: ItemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Item collection)
        {
            try
            {
                _db.Items.Add(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemController/Edit/5
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

        // GET: ItemController/Delete/5
        public ActionResult Delete(int id)
        {
            var _Var = _db.Items.Include(s => s.Item_Groups).Include(s => s.Item_SubGroups).FirstOrDefault(i => i.Item_ID == id);
            return View(_Var);
        }

        // POST: ItemController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Item collection)
        {
            try
            {
                collection.Item_ID = id;
                _db.Items.Remove(collection);
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
