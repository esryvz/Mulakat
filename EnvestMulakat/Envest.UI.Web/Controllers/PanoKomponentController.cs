using Envest.BLL;
using Envest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Envest.UI.Web.Controllers
{
    public class PanoKomponentController : Controller
    {
        PanoKomponentManager panoKomponentManager = new PanoKomponentManager();
        KomponentManager komponentManager = new KomponentManager();
        // GET: PanoKomponent
        public ActionResult Index(int ID)
        {
            var list = (from x in komponentManager.GetAll()
                        select new SelectListItem
                        {
                            Text = x.BilesenAdi,
                            Value = x.KomponentID.ToString()
                        });

            ViewBag.Komponent = list;
            ViewBag.PanoID = ID;
            return View(panoKomponentManager.GetAll(ID));
        }

        [HttpPost]
        public ActionResult Create(PanoKomponent entity)
        {
            
            panoKomponentManager.Create(entity);
            return RedirectToAction("Index",new { ID = entity.PanoID});
        }

     
        public ActionResult Delete(int ID,int PanoID)
        {
            panoKomponentManager.Delete(ID);
            return RedirectToAction("Index", new { ID = PanoID });
        }
    }
}