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
        public DbSet<FilmBilgi> FILMBILGILERI { get; set; }
        public DbSet<Salon> SALONLAR { get; set; }
        public DbSet<Seans> SEANSLAR { get; set; }
        public DbSet<Bilet> BILETLER { get; set; }
        public DbSet<Satis> SATISLAR { get; set; }
        public DbSet<BiletSatis> BILETSATISLARI { get; set; }
    }
}
