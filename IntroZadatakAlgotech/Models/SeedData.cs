using IntroZadatakAlgotech.Data;
using Microsoft.EntityFrameworkCore;

namespace IntroZadatakAlgotech.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {

                context.Database.EnsureCreated();

                // ako nema ni jednog kandidata u bazi ubaci sledece
                if (!context.Kandidati.Any())
                {
                    context.Kandidati.AddRange(
                        new Kandidat
                        {
                            Ime = "Petar",
                            Prezime = "Petrovic",
                            JMBG = "0123456789123",
                            Email = "petarpetrovic@gmail.com",
                            Obrazovanje = "diplomirani inzenjer telekomunikacija",
                            BrojTelefona = "0641231234"
                        },
                        new Kandidat
                        {
                            Ime = "Marko",
                            Prezime = "Markovic",
                            JMBG = "1123456789123",
                            Email = "markomarkovic@gmail.com",
                            Obrazovanje = "diplomirani filolog",
                            BrojTelefona = "0621231234"
                        },
                        new Kandidat
                        {
                            Ime = "Mika",
                            Prezime = "Mikic",
                            JMBG = "2123456789123",
                            Email = "mikamikic@gmail.com",
                            Obrazovanje = "diplomirani inzenjer informatike",
                            BrojTelefona = "0631231234"
                        },
                        new Kandidat
                        {
                            Ime = "Ana",
                            Prezime = "Anic",
                            JMBG = "3123456789123",
                            Email = "anaanic@gmail.com",
                            Obrazovanje = "diplomirani psiholog",
                            BrojTelefona = "0691231234"
                        }
                    );
                    context.SaveChanges();
                }
                
                // ako nema ni jedne pozicije u bazi ubaci sledece
                if (!context.Pozicije.Any())
                {
                    context.Pozicije.AddRange(
                        new Pozicija
                        {
                            Naziv = "Prevodilac za spanski jezik",
                            Opis = "Nasoj kompaniji je potrebano pojacanje u vidu novog prevodioca spanskog jezika. Pozeljno je prethodno iskustvo ali nije neophodno.",
                            Lokacija = "Beograd, Vozdovac",
                            NacinRada = "OFFICE",
                            DatumObjave = DateTime.Now,
                            DatumKrajaPrijave = DateTime.Now.AddDays(30),
                            Status = "OTVORENA"
                        },
                        new Pozicija
                        {
                            Naziv = "DevOps inzenjer",
                            Opis = "Nasoj kompaniji je potrebano pojacanje u vidu novog DevOps inzenjera. Pozeljno je prethodno iskustvo ali nije neophodno.",
                            Lokacija = "Beograd, Vozdovac",
                            NacinRada = "HYBRID",
                            DatumObjave = DateTime.Now,
                            DatumKrajaPrijave = DateTime.Now.AddDays(39),
                            Status = "OTVORENA"
                        },
                        new Pozicija
                        {
                            Naziv = "System administrator",
                            Opis = "Nasoj kompaniji je potrebano pojacanje u vidu novog system administratora. Pozeljno je prethodno iskustvo ali nije neophodno.",
                            Lokacija = "Beograd, Vozdovac",
                            NacinRada = "HYBRID",
                            DatumObjave = DateTime.Now,
                            DatumKrajaPrijave = DateTime.Now.AddDays(38),
                            Status = "OTVORENA"
                        },
                        new Pozicija
                        {
                            Naziv = "Softver inzenjer",
                            Opis = "Nasoj kompaniji je potrebano pojacanje u vidu novog softver inzenjera. Pozeljno je prethodno iskustvo ali nije neophodno.",
                            Lokacija = "Beograd, Vozdovac",
                            NacinRada = "HYBRID",
                            DatumObjave = DateTime.Now,
                            DatumKrajaPrijave = DateTime.Now.AddDays(31),
                            Status = "OTVORENA"
                        },
                        new Pozicija
                        {
                            Naziv = "HR intern",
                            Opis = "Nasoj kompaniji je potrebano pojacanje u vidu novog HR praktikanta. Prethodno iskustvo nije neophodno.",
                            Lokacija = "Beograd, Vozdovac",
                            NacinRada = "OFFICE",
                            DatumObjave = DateTime.Now,
                            DatumKrajaPrijave = DateTime.Now.AddDays(30),
                            Status = "OTVORENA"
                        }
                    );
                    context.SaveChanges();
                }

                // ako nema ni jedne prijave u bazi ubaci sledece
                if (!context.Prijave.Any())
                {
                    context.Prijave.AddRange(
                        new Prijava
                        {
                            KandidatID = 2,
                            PozicijaID = 1,
                            DatumPrijave = DateTime.Now.AddDays(1),
                            Status = "CEKA"
                        },
                        new Prijava
                        {
                            KandidatID = 1,
                            PozicijaID = 2,
                            DatumPrijave = DateTime.Now.AddDays(2),
                            Status = "CEKA"
                        },
                        new Prijava
                        {
                            KandidatID = 3,
                            PozicijaID = 2,
                            DatumPrijave = DateTime.Now.AddDays(3),
                            Status = "CEKA"
                        },
                        new Prijava
                        {
                            KandidatID = 1,
                            PozicijaID = 3,
                            DatumPrijave = DateTime.Now.AddDays(1),
                            Status = "CEKA"
                        },
                        new Prijava
                        {
                            KandidatID = 3,
                            PozicijaID = 3,
                            DatumPrijave = DateTime.Now.AddDays(2),
                            Status = "CEKA"
                        },
                        new Prijava
                        {
                            KandidatID = 1,
                            PozicijaID = 4,
                            DatumPrijave = DateTime.Now.AddDays(3),
                            Status = "CEKA"
                        },
                        new Prijava
                        {
                            KandidatID = 3,
                            PozicijaID = 4,
                            DatumPrijave = DateTime.Now.AddDays(1),
                            Status = "CEKA"
                        }, new Prijava
                        {
                            KandidatID = 4,
                            PozicijaID = 5,
                            DatumPrijave = DateTime.Now.AddDays(2),
                            Status = "CEKA"
                        }

                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
