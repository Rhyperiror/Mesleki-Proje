using CinemaHub.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaHub.DB
{
    public class Db_Context : DbContext
    {
        public Db_Context(DbContextOptions<Db_Context> options) : base(options)
        {

        }

        public DbSet<Kullanici> KULLANICILAR { get; set; }
    }
}
