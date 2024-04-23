using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroZadatakAlgotech.Models
{
    public class Prijava
    {
        public int PrijavaID { get; set; }

        [Required(ErrorMessage = "Polje IdKandidata ne moze biti NULL")]
        public int KandidatID { get; set; }

        [ForeignKey("KandidatID")]
        public Kandidat Kandidat { get; set; } // relacija

        [Required(ErrorMessage = "Polje IdPozicije ne moze biti NULL")]
        public int PozicijaID { get; set; }

        [ForeignKey("PozicijaID")]
        public Pozicija Pozicija { get; set; } // relacija

        [Required(ErrorMessage = "Polje DatumPrijave ne sme biti NULL")]
        [DataType(DataType.Date, ErrorMessage = "Polje DatumPrijave treba da bude u DateTime formatu")]
        [DisplayName("Datum prijave")]
        public DateTime DatumPrijave { get; set; }

        [Required(ErrorMessage = "Polje Status ne sme biti NULL")]
        [RegularExpression("^(PRIHVACEN | ODBIJEN | CEKA)$", ErrorMessage = "Polje Status ima vrednost razlicitu od OTVORENA/ZATVORENA")]
        [DefaultValue("CEKA")]
        public string Status { get; set; }


    }
}
