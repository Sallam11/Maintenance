using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Maintenance.Data;
using Maintenance.Models;
using System.Security.Claims;

namespace Maintenance.Controllers
{
	public class LoginController : Controller
	{

        private readonly MaintenanceDbContext _db;

        public LoginController(MaintenanceDbContext context)
        {
            _db = context;
        }

        // GET: LoginController/Create
        public ActionResult login()
		{
			return View();
		}

        //// POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login collection)
        {

            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(LoginController.login), "Login");
            }
            var user = _db.Users.Where(x => x.User_Name.Contains(collection.UserName));
            if (user.Count() > 0)
            {
                var password = _db.Users.Where(x => x.User_Name.Contains(collection.UserName) && x.User_Password.Contains(collection.Password ));
                if (password.Count() > 0)
                {
                    return RedirectToAction(nameof(HomeController.Index), "Home");

                    //ViewTemplate[]
                    //{
                    //    var identity = new ClaimsIdentity(IdentityConstants.ApplicationScheme);
                    //    identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id));
                    //    identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
                    //    await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, new ClaimsPrincipal(identity));

                    //}

                }
                else
                {
                    ModelState.AddModelError("", "Invalid Password");
                  
                }


            }
            else
            {
                ModelState.AddModelError("", "Invalid UserName");

            }
            return View();
        }


	}
}
