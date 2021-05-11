using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaHub.Models
{
    public class Salon
    {
        [Key]
        public int ID { get; set; }
        public string SALONADI { get; set; }
        public int KAPASITE { get; set; }
        public int KOLTUKNUMARA { get; set; }
    }
}
