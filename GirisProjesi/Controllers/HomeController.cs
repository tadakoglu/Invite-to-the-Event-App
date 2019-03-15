using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GirisProjesi.Models;
using GirisProjesi.Models.VeriAmbari;

namespace GirisProjesi.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() // ViewResult ile HTML ve ASP.NET Core View'leri sunuculur/render edilir.
        {
            int saat = DateTime.Now.Hour;
            ViewData["Mesaj"] = saat < 12 ? "Günaydın" : "İyi akşamlar";
            return View("DavetView");
        }
        public ViewResult KatilacaginiBildir()
        {
            return View();
        }
        [HttpPost]
        public ViewResult KatilacaginiBildir(DavetEdilenKisi davetEdilenKisi)
        {
            if (ModelState.IsValid)
            {
                Ambar.Ekle(davetEdilenKisi);
                return View("BilgiMesaji", davetEdilenKisi);
            }
            else
            { // Veri doğrulama da bir sıkıntı vardır, tekrar aynı sayfayı hatalarla birlikte görüntüle.
                return View(davetEdilenKisi);
            }
            
        }
        [HttpGet]
        public ViewResult KimlerKatiliyor()
        {
            IEnumerable<DavetEdilenKisi> katilacaklar = Ambar.Cevaplar.Where(c=> c.KatilacakMi==true).ToList();
            return View("KimlerKatiliyor", katilacaklar);
        }
        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
