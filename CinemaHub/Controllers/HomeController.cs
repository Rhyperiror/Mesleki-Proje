using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CinemaHub.DB;
using CinemaHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CinemaHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Db_Context _context;

        public HomeController(ILogger<HomeController> logger, Db_Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Kullanici giris)
        {
            /*
             SELECT * FROM KULLANICILAR;
             
            List<Kullanici> viewList = _context.KULLANICILAR.ToList();*/
            
            var girişBilgileri = _context.KULLANICILAR.FirstOrDefault(
                db => db.KullaniciAdi == giris.KullaniciAdi &&
                db.Sifre == giris.Sifre);

            if (girişBilgileri != null)
            {
                //sisteme giriş yapacak
            }

            return View("Privacy");
        }

        public IActionResult Logout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
