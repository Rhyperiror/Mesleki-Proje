using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaHub.Models
{
    public class Seans

    {
        [Key]
        public int ID { get; set; }
        public int SAAT { get; set; }
    }
}
