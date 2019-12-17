using kitaptakas.Ayarlar;
using kitaptakas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kitaptakas.Controllers
{
    public class AnasayfaKullaniciKayitController : Controller
    {
        AdminContext db = new AdminContext();
        // GET: AnasayfaKayit
        [HttpGet]
        public ActionResult AnasayfaKayit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AnasayfaKayit(Kullanicilar k,HttpPostedFileBase resimGelen)
        {
            ResimIslem r = new ResimIslem();
            string resimAdi = r.Ekle(resimGelen, "kullaniciResim");
            //if (resimAdi == "uzanti")
            //{
            //    ViewBag.Hata = "Lütfen .jpg veya .png uzantılı resim ekleyiniz.";
            //    return Redirect("AnasayfaKullaniciKayit/AnasayfaKayit");
            //}
            //else if (resimAdi == "boyut")
            //{
            //    ViewBag.Hata = "En fazla 1 MB dosya yükleyebilirsiniz.";
            //    return Redirect("AnasayfaKullaniciKayit/AnasayfaKayit");
            //}
            //else
            //{
            k.kullaniciResimYolu = resimAdi;
                db.Kullanicilar.Add(k);
                db.SaveChanges();
                ViewBag.Sonuc = k.kullaniciAdi + " " + k.kullaniciSoyadi + " eklendi.";
            return RedirectToAction("Index", "AnasayfaLogin");

            //}

        }
    }
}