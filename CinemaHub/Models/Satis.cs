using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaHub.Models
{
    public class Satis
    {
        [Key]
        public int ID { get; set; }
        public DateTime TARIH { get; set; }
        public int MUSTERIID { get; set; }
        public int FIYAT { get; set; }
    }
}
