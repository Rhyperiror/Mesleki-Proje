using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaHub.Models
{
    public class Bilet
    {
        [Key]
        public int ID { get; set; }
        public int FILMID { get; set; }
        public int SALONID { get; set; }
        public int SEANSID { get; set; }
        public int TARIH { get; set; }
        public int KOLTUKNO { get; set; }
    }
}
