using IntroZadatakAlgotech.Models;
using Microsoft.EntityFrameworkCore;

namespace IntroZadatakAlgotech.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // ovo bi bilo potrebno da je za primarni kljuc Prijava-e koriscen kompozitni primarni kljuc od stranih kljuceva kandidata i pozicije
        // posto sam se odlucio da koristim vestacki primarni kljuc za Prijavu nije neophodno dodatno preklapanje metode OnModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            /*modelBuilder.Entity<Prijava>().HasKey(p => new
            {
                p.KandidatID,
                p.PozicijaID
            });

            modelBuilder.Entity<Prijava>().HasOne(k => k.Kandidat).WithMany(p => p.Prijave).HasForeignKey(k => k.KandidatID);

            modelBuilder.Entity<Prijava>().HasOne(poz => poz.Pozicija).WithMany(p => p.Prijave).HasForeignKey(poz => poz.PozicijaID);*/

            modelBuilder.Entity<Prijava>().HasIndex(p => new {p.KandidatID, p.PozicijaID}).IsUnique();


        }

        public DbSet<Kandidat> Kandidati { get; set; }

        public DbSet<Pozicija> Pozicije { get; set; }

        public DbSet<Prijava> Prijave { get; set; }
    }
}
