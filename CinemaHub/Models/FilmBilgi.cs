using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaHub.Models
{
    public class FilmBilgi
    {
        [Key]
        public int ID { get; set; }
        public string FILMADI { get; set; }
        public string FILMTURU { get; set; }
        public string YONETMEN { get; set; }
        public string OYNUCULAR { get; set; }
        public int VIZYONTARIH { get; set; }
        public int SURE { get; set; }
        public int YAPIMTARIH { get; set; }
        public string ULKE { get; set; }
    }
}
