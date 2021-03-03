using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CinemaHub.DB;
using CinemaHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IActionResult Kayit()
        {
            Kullanici yeniKisiHazirlik = new Kullanici();

            /*
             drop down listetede görünmesini istediğimiz Rol ve rol id değerleri 
            Roller tablosunda olduğundan, bu sayfa yüklenirken bu değerlerin ilgili 
            drop down elemanına yüklenmesi gerek. Burada sadece rollerin içerisinde
            değerler model sınıfını view e yönlendiriyoruz ki sayfa yüklendiğinde 
            roller drop down list i dolu gelsin.
             */
            yeniKisiHazirlik.Roller = _context.ROLLER.Select(item => new SelectListItem(){
                Value = item.ROLID.ToString(), //kullanıcının seçtiği rolün id sini kaydetmek için
                Text = item.ROL //kullanıcı rollerin metinsel karşılıklarını görmesi için
            }).ToList();

            return View(yeniKisiHazirlik);
        }

        [HttpPost]
        public IActionResult Kayit(Kullanici yeniKisi)
        {
            yeniKisi.ID = 9;        //her seferinde değiştir
            _context.Add(yeniKisi); /*yeniKisi Kullanici sınıfının nesnesi olduğundan EF 
                                     bu nesneyi KULLANICILAR tablosuna ekleyeceğini(mapleyeceğini) biliyor*/
            _context.SaveChanges(); /*bu satırla da tabloya ekleme sırasına alınan kaydı maplenen
                                     tabloya işler*/


            //return View(); //kayıt olunduktan sonra giriş sayfasında yönlendirilebilir
            return RedirectToAction("Kayit"); //roller drop down listesinin içerisini tekrar doldurmak için
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
