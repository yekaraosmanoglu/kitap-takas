using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace kitaptakas.Ayarlar
{
    public class ResimIslem
    {
        public string Ekle(HttpPostedFileBase resim, string klasor)
        {
            //1- uzantı
            //2- boyut
            //3- ad

            string uzanti = Path.GetExtension(resim.FileName);
            if (!(uzanti == ".jpg" || uzanti == ".png"))
            {
                return "uzanti";
            }
            if (resim.ContentLength > 10000000)
            {
                return "boyut";
            }

            //string ad = Guid.NewGuid().ToString() + uzanti;

            //Bitmap res = new Bitmap(Image.FromStream(resim.InputStream));
            //res.Save(HttpContext.Current.Server.MapPath("/Content/Resimler/" + klasor + "/") + ad);
            Random rstgele = new Random();
            string ResimUzantisi = Path.GetExtension(resim.FileName);
            string ResimAdi = Guid.NewGuid().ToString() + ResimUzantisi;
            //Geçici olarak FileUpload nesnemizdeki resmi Resimler dizinine kayıt ediyoruz.
            resim.SaveAs(HttpContext.Current.Server.MapPath("/Content/resimler/") + ResimAdi);
            //Şimdi ise bu kayıt ettiğimiz resmi Bitmap nesnesi şeklinde alıyoruz.
            Bitmap Resim = new Bitmap(HttpContext.Current.Server.MapPath("/Content/resimler/") + ResimAdi);
            int Genislik = 900;
            int Yukseklik = 600;
            //Boyutlarını veriyoruz.
            Size Boyut = new Size(Genislik, Yukseklik);
            //Resmi boyutlandırıyoruz.
            Bitmap BoyutlandirilmisResim = new Bitmap(Resim, Boyut);
            string BoyutlanmisKayit = "/Content/resimler/" + klasor + "/" + ResimAdi;
            //Boyutlanmış resmi Resimler/BoyutluResimler dizinine kayıt ediyoruz.
            BoyutlandirilmisResim.Save(HttpContext.Current.Server.MapPath(BoyutlanmisKayit), ImageFormat.Jpeg);
            Resim.Dispose();
            BoyutlandirilmisResim.Dispose();
            //Geçici olarak kaydedilen resmi siliyoruz.
            FileInfo IlkResimDosyasi = new FileInfo(HttpContext.Current.Server.MapPath("/Content/resimler/") + ResimAdi);
            IlkResimDosyasi.Delete();
            return ResimAdi;
        }
    }
}