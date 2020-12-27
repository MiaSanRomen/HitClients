using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using HitClients.Cloud.Models;
using HitClients.Cloud.Providers;
using System.Web.Security;

namespace HitClients.Cloud.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
       

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = UserProvider.CheckUser(model.Email, model.Password);


            switch (result)
            {
                case SignInStatus.Success:
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    return RedirectToAction("Index", "Main");
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(model);
            }
        }
    }
}