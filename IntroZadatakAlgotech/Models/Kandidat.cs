using System.ComponentModel.DataAnnotations;

namespace IntroZadatakAlgotech.Models
{
    public class Kandidat
    {
        public int KandidatID { get; set; }

        [Required(ErrorMessage = "Polje Ime ne sme biti NULL")]
        [MaxLength(50)]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Polje Prezime ne sme biti NULL")]
        [MaxLength(50)]
        public string Prezime { get; set; }

        [Required(ErrorMessage = "Polje JMBG ne sme biti NULL")]
        [MaxLength(13, ErrorMessage = "JMBG mora imati 13 cifara")]
        [MinLength(13, ErrorMessage = "JMBG mora imati 13 cifara")]
        public string JMBG { get; set; }

        [Required(ErrorMessage = "Polje Obrazovanje ne sme biti NULL")]
        [MaxLength(100)]
        public string Obrazovanje { get; set; }

        [Required(ErrorMessage = "Polje BrojTelefona ne sme biti NULL")]
        [MaxLength(13, ErrorMessage = "Broj telefona moze imati maksimalno 13 cifara")]
        public string BrojTelefona { get; set; }

        // Relacije
        public ICollection<Prijava> Prijave { get; set; }

    }
}
