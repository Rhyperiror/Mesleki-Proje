using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaHub.Models
{
    public class BiletSatis
    {
        [Key]
        public int BILETID { get; set; }
        [Key]
        public int SATISID { get; set; }
    }
}
