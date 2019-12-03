using Envest.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Envest.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        SatisManager satisManager = new SatisManager();
        // GET: Home
        public ActionResult Index()
        {
            
            return View(satisManager.GetAll());
        }
    }
}