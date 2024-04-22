using IntroZadatakAlgotech.Models;
using Microsoft.EntityFrameworkCore;

namespace IntroZadatakAlgotech.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prijava>().HasKey(p => new
            {
                p.KandidatID,
                p.PozicijaID
            });

            modelBuilder.Entity<Prijava>().HasOne(k => k.Kandidat).WithMany(p => p.Kandidati_Prijave).HasForeignKey(k => k.KandidatID);

            modelBuilder.Entity<Prijava>().HasOne(poz => poz.Pozicija).WithMany(p => p.Kandidati_Prijave).HasForeignKey(poz => poz.PozicijaID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Kandidat> Kandidati { get; set; }

        public DbSet<Pozicija> Pozicije { get; set; }

        public DbSet<Prijava> Prijave { get; set; }
    }
}
