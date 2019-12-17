using kitaptakas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kitaptakas.Controllers
{
  
    public class AdminController : Controller
    {
        AdminContext db = new AdminContext();

        public ActionResult Index()
        {
            AdminContext db = new AdminContext();
            var adminListesi = db.Kullanicilar.Where(x=>x.yetkiID==1).ToList();
            return View(adminListesi);
        }
        public ActionResult KullaniciListele()
        {
            AdminContext db = new AdminContext();
            var kullaniciListesi = db.Kullanicilar.ToList();
            return View(kullaniciListesi);

        }

        public ActionResult AdminEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminEkle(Kullanicilar k)
        {
            AdminContext db = new AdminContext();
            db.Kullanicilar.Add(k);
            db.SaveChanges();
            return RedirectToAction("Index"); 
        }

        public ActionResult KullaniciSil(int id)
        {
            AdminContext db = new AdminContext();
            Kullanicilar kullanici = db.Kullanicilar.Where(x => x.kullaniciID == id).SingleOrDefault();
            db.Kullanicilar.Remove(kullanici);
            db.SaveChanges();

            return RedirectToAction("KullaniciListele");
        }


        public ActionResult AdminSil(int id)
        {
            AdminContext db = new AdminContext();
            Kullanicilar SilinecekAdmin = db.Kullanicilar.Where(x => x.kullaniciID == id).SingleOrDefault();
            db.Kullanicilar.Remove(SilinecekAdmin);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       
        public ActionResult AdminDuzenle(int id)
        {
            AdminContext db = new AdminContext();
            Kullanicilar DuzenlenecekAdmin= db.Kullanicilar.Where(x => x.kullaniciID == id).SingleOrDefault();
            return View(DuzenlenecekAdmin);


        }

        [HttpPost]
        public ActionResult AdminDuzenle(Kullanicilar duzenlenmisAdmin)
        {
            AdminContext db = new AdminContext();
            Kullanicilar data = db.Kullanicilar.Where(x => x.kullaniciID == duzenlenmisAdmin.kullaniciID).SingleOrDefault();
            data.kullaniciAdi = duzenlenmisAdmin.kullaniciAdi;
            data.kullaniciSoyadi = duzenlenmisAdmin.kullaniciSoyadi;
            data.eMail = duzenlenmisAdmin.eMail;
            data.sifre = duzenlenmisAdmin.sifre;
            data.yetkiID = duzenlenmisAdmin.yetkiID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

     

        }
}