using HitClients.Cloud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HitClients.Cloud.Controllers
{
    [Authorize]
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Settings()
        {
            var setting = new SettingModels();
            setting.Login = "login";
            return View(setting);
        }
    }
}