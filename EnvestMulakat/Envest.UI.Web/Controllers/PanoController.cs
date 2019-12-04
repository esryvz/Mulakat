using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Envest.BLL;
using Envest.Model;
using Envest.UI.Web.Models;

namespace Envest.UI.Web.Controllers
{
    public class PanoController : Controller
    {       
        PanoManager panoManager = new PanoManager();

        // GET: Pano
        public ActionResult Index()
        {
            return View(panoManager.GetAll());
        }

        // GET: Pano/Details/5
        public ActionResult Details(int ID)
        {
            return RedirectToAction("PanoKomponent", "Index", new { id = ID });
        }

        // GET: Pano/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pano/Create       
        [HttpPost]       
        public ActionResult Create(Pano entity)
        {
            var result = panoManager.CreatePano(entity);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Pano/Edit/5
        public ActionResult Edit(int ID)
        {
            return View(panoManager.FindByID(ID));
        }

        // POST: Pano/Edit/5
        [HttpPost]      
        public ActionResult Edit(Pano entity)
        {
            var result = panoManager.UpdatePano(entity);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Pano/Delete/5
        public ActionResult Delete(int ID)
        {
            return View(panoManager.FindByID(ID));
        }

        // POST: Pano/Delete/5
        [HttpPost, ActionName("Delete")]        
        public ActionResult Deleted(int ID)
        {
            var result = panoManager.DeletePano(ID);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(panoManager.FindByID(ID));
            }
        }

       
    }
}
