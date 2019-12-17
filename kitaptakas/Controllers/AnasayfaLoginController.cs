using kitaptakas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kitaptakas.Controllers
{
    public class AnasayfaLoginController : Controller
    {
        AdminContext db = new AdminContext();
        // GET: AnasayfaLogin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string mail,string sifre)
        {
            Kullanicilar kullanici = db.Kullanicilar.Where(x => x.eMail == mail && x.sifre == sifre).SingleOrDefault();

            if (kullanici==null)
            {
                ViewBag.Hata = "Kullanıcı Bulunamadı.";
            }
            else if(kullanici.Yetki.yetkiAdi=="admin")
            {
                Session["kullanici"] = kullanici;
                return RedirectToAction("Index", "Admin");
            }
            else if(kullanici.Yetki.yetkiAdi=="kullanıcı")
            {
                Session["kullanici"] = kullanici;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}