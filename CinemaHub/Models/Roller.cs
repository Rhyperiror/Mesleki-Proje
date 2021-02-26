using System.ComponentModel.DataAnnotations;

namespace CinemaHub.Models
{
    public class Roller
    {
        [Key]
        public int ID { get; set; }
        public string ROL { get; set; }
        public int ROLID { get; set; }
    }
}
