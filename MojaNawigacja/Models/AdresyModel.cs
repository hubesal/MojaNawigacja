using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MojaNawigacja.Models
{
    [Table("Adresy")]
    public class AdresyModel
    {
        [Key]
        public int IdTrasy { get; set; }
        public string MiejsceWyjazdu { get; set; }
        public string MiejsceDocelowe { get; set; }
        public DateTime DataDodania { get; set; }

    }
}