using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Maintenance.Data;

namespace Maintenance.Controllers
{
    public class Machine_MovementController : Controller
    {
        // GET: Machine_MovementController
        private readonly MaintenanceDbContext _db;

        public Machine_MovementController(MaintenanceDbContext context)
        {
            _db = context;
        }

        public ActionResult Index()
        {
            var _var = _db.Machine_Movements.Include(x => x.Work_Type)
                                             .Include(x => x.Movement_Type)
                                             .Include(x => x.Machine)
                                             .Include(x => x.Employee).ToList();
            return View(_var);
        }

        // GET: Machine_MovementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Machine_MovementController/Create
        public ActionResult Create()
        {
            ViewBag.Employees = _db.Employees.ToList();
            ViewBag.Machines = _db.Machines.ToList();
            ViewBag.Movement_Types = _db.Movement_Types.ToList();
            ViewBag.Work_Types = _db.Work_Types.ToList();
            return View();
        }

        // POST: Machine_MovementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Machine_Movement collection)
        {
            try
            {
                collection.MachineMovement_CreatedDate = DateTime.Now;
                collection.MachineMovement_CreatedUserID = 1;
                var _var = _db.Machine_Movements.Add(collection);

                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Machine_MovementController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Employees = _db.Employees.ToList();
            ViewBag.Machines = _db.Machines.ToList();
            ViewBag.Movement_Types = _db.Movement_Types.ToList();
            ViewBag.Work_Types = _db.Work_Types.ToList();
            var _var = _db.Machine_Movements.FirstOrDefault(x => x.MachineMovement_ID == id);
            return View(_var);
        }

        // POST: Machine_MovementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Machine_Movement collection)
        {
            try
            {
                _db.Machine_Movements.Update(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Machine_MovementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Machine_MovementController/Delete/5
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
