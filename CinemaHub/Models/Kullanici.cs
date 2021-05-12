using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaHub.Models
{
    public class Kullanici
    {
        [Key]
        public int ID { get; set; }
        public string KULLANICIADI { get; set; }
        public string KULLANICISOYADI { get; set; }
        public string EPOSTA { get; set; }
        public string SIFRE { get; set; }
        public int ROL { get; set; }
        public DateTime KAYITTARIH { get; set; }

    }
}
