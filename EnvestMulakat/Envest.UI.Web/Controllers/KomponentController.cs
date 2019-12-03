using Envest.BLL;
using Envest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Envest.UI.Web.Controllers
{
    public class KomponentController : Controller
    {
        KomponentManager komponentManager = new KomponentManager();
        // GET: Komponent
        public ActionResult Index()
        {
            return View(komponentManager.GetAll());
        }
    }
}