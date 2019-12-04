using Envest.BLL;
using Envest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Envest.UI.Web.Controllers
{
    public class SatisController : Controller
    {
        PanoManager panoManager = new PanoManager();
        SatisManager satisManager = new SatisManager();
        // GET: Satis
        public ActionResult Create()
        {
            var panoList = (from x in panoManager.GetAll()
                            select new SelectListItem
                            {
                                Text = x.PanoAdi,
                                Value = x.PanoID.ToString()
                            });
            ViewBag.Pano = panoList;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Satis satis)
        {
            var maliyet = panoManager.FindByID(satis.PanoID).Maliyet;
            var kar = panoManager.FindByID(satis.PanoID).Kar;

            var toplamTutar = maliyet * satis.Adet;
            var toplamSatisTutar = maliyet + ((maliyet * kar) / 100) - ((maliyet * satis.IndirimOrani) / 100);

            Satis yeniSatis = new Satis();
            yeniSatis.Musteri = satis.Musteri;
            yeniSatis.PanoID = satis.PanoID;
            yeniSatis.Adet = satis.Adet;
            yeniSatis.IndirimOrani = satis.IndirimOrani;
            yeniSatis.ToplamTutar = toplamTutar;
            yeniSatis.ToplamSatisTutari = toplamSatisTutar;
            yeniSatis.BirimFiyat = maliyet;

            var result = satisManager.Create(yeniSatis);
            if (result != 0)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
    }
}