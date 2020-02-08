using OIBValidation.Models.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OIBValidation.Models
{
    public class Osoba
    {
        [Required(ErrorMessage = "Unesite ime")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Unesite prezime")]
        public string Prezime { get; set; }

        [OIBValidator(ErrorMessage = "Pogresan format OIB-a")]
        public string OIB { get; set; }
    }
}