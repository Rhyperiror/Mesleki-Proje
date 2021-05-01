using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaHub.Models
{
    public class Kullanici
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        
    }
}
