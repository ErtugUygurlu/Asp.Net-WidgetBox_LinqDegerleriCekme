using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LinqDegerleriCekme.Models.Entity;

namespace LinqDegerleriCekme.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        MuzikOgrenciKayitEntities db = new MuzikOgrenciKayitEntities();
        public ActionResult Index()
        {
            var deger1 = db.TBLOGRENCILER.Count();
            var deger2 = db.TBLOGRENCILER.Where(x => x.Enstruman == "gitar").Count();
            ViewBag.dgr1 = deger1;
            ViewBag.dgr2 = deger2;
            return View();
        }
    }
}