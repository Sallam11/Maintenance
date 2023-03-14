using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Maintenance.Data;
using Maintenance.Models;

namespace Maintenance.Controllers
{
    public class OrdersStatusController : Controller
    {

        private readonly MaintenanceDbContext _db;

        public OrdersStatusController(MaintenanceDbContext context)
        {
            _db = context;
        }
        
        // GET: Work_TypeController
        public ActionResult Index()
        {
            var _var = _db.OrdersStatuss.ToList();
            return View(_var);
        }

        // GET: Work_TypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Work_TypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Work_TypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrdersStatus collection)
        {
            try
            {
                var _var = _db.OrdersStatuss.Add(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Work_TypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Work_TypeController/Edit/5
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

        // GET: Work_TypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Work_TypeController/Delete/5
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
