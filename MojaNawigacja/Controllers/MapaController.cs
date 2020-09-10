using Microsoft.Ajax.Utilities;
using MojaNawigacja.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;

namespace MojaNawigacja.Controllers
{
    public class MapaController : Controller
    {
        private readonly NawigacjaDbContext db = new NawigacjaDbContext();

        // GET: Mapa
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formularz)
        {
            if (ModelState.IsValid)
            {
                var nowaTrasa = new AdresyModel
                {
                    MiejsceWyjazdu = formularz["miejsceWyjazdu"].ToString(),
                    MiejsceDocelowe = formularz["miejsceDocelowe"].ToString(),
                    DataDodania = DateTime.Now
                };

                db.Adresy.Add(nowaTrasa);
                db.SaveChanges();

                return View(nowaTrasa);
            }

            return View();
        }

        public ActionResult Transfer()
        {
            var Cyfry = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Cyfry.Add(i);
            }

            //ViewData
            ViewData["Imie"] = "Mikołaj";
            ViewData["Nazwisko"] = "Kopernik";
            ViewData["Cyfry"] = Cyfry;

            //ViewBag
            ViewBag.Imie = "Albert";
            ViewBag.Nazwisko = "Einstein";
            ViewBag.Cyfry = Cyfry;

            return View();
        }

        public ActionResult WyswietlTrasy()
        {
            return View("Trasy", db);
        }

        public ActionResult UsunTrase(AdresyModel adres)
        {
            if (db.Adresy.Count() > 0)
            {
                AdresyModel trasaDoUsuniecia = db.Adresy.Where(s => s.IdTrasy == adres.IdTrasy).First();
                db.Adresy.Remove(trasaDoUsuniecia);
                db.SaveChanges();
            }

            return View("Trasy", db);
        }
    }
}