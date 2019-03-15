using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GirisProjesi.Models
{
    public class DavetEdilenKisi
    {
        [Required(ErrorMessage ="Lütfen isminizi yazınız")]
        //[RegularExpression("([A-Za-z])+( [A-Za-z]+)",ErrorMessage ="Lütfen geçerli bir isim yazın")]
        public string Isim { get; set; }

        [Required(ErrorMessage = "Lütfen eposta adresinizi yazınız")]
        [RegularExpressionAttribute(".+\\@.+\\..+", ErrorMessage = "Lütfen geçerli bir eposta belirtiniz")]
        public string Eposta { get; set; }

        [Required(ErrorMessage = "Lütfen telefon numaranızı yazınız")]
        public string Telefon { get; set; }
        public bool? KatilacakMi { get; set; }
    }
}
