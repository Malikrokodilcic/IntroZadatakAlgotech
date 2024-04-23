using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IntroZadatakAlgotech.Models
{

    public class Pozicija
    {
        public int PozicijaID { get; set; }

        [Required(ErrorMessage = "Polje Naziv ne sme biti NULL")]
        [MaxLength(50)]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Polje Opis ne sme biti NULL")]
        [MaxLength (1000)]
        public string Opis { get; set; }

        [Required(ErrorMessage = "Polje Lokacija ne sme biti NULL")]
        [MaxLength(50)]
        public string Lokacija { get; set; }

        [Required(ErrorMessage = "Polje NacinRada ne sme biti NULL")]
        [RegularExpression("^(REMOTE | OFFICE | HYBRID)$", ErrorMessage = "Polje NacinRada ima vrednost razlicitu od REMOTE/OFFICE/HYBRID")]
        [DefaultValue("HYBRID")]
        [DisplayName("Nacin rada")]
        public string NacinRada { get; set; }

        [Required(ErrorMessage = "Polje DatumObjave ne sme biti NULL")]
        [DataType(DataType.Date, ErrorMessage = "Polje DatumObjave treba da bude u DateTime formatu")]
        [DisplayName("Datum objave")]
        public DateTime DatumObjave { get; set; }

        [Required(ErrorMessage = "Polje DatumKrajaPrijave ne sme biti NULL")]
        [DataType(DataType.Date, ErrorMessage = "Polje DatumKrajaPrijave treba da bude u DateTime formatu")]
        [DisplayName("Datum kraja prijave")]
        public DateTime DatumKrajaPrijave { get; set; }

        [Required(ErrorMessage = "Polje Status ne sme biti NULL")]
        [RegularExpression("^(OTVORENA | ZATVORENA)$", ErrorMessage = "Polje Status ima vrednost razlicitu od OTVORENA/ZATVORENA")]
        [DefaultValue("OTVORENA")]
        public string Status { get; set; }

        // Relacije
        public ICollection<Prijava> Prijave { get; set; }
    }
}
