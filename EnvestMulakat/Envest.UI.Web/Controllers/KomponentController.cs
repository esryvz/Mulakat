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

        public ActionResult Edit(int ID)
        {
            return View(komponentManager.FindByID(ID));
        }

        [HttpPost]       
        public ActionResult Edit(Komponent entity)
        {
            var result = komponentManager.UpdateComponent(entity);
            if (result !=0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(entity);
            }
        }

        public ActionResult Create()
        {
            List<string> paraBirimi = new List<string>();
            paraBirimi.Add("TRY");
            paraBirimi.Add("USD");
            paraBirimi.Add("EUR");
            ViewBag.Birim = paraBirimi;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Komponent entity)
        {
            var result = komponentManager.CreateComponent(entity);
            if (result !=0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }

        public ActionResult Delete(int ID)
        {
            return View(komponentManager.FindByID(ID));
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Deleted(int ID)
        {
            var result = komponentManager.DeleteComponent(ID);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(komponentManager.FindByID(ID));
            }
        }
    }
}