using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TPLOCAL1.Models
{
    public class FormulaireModel
    {
        public int Id;
        [Required(ErrorMessage ="Please pick a name")]
        public string nom { get; set; }
        [Required]
        public string prenom { get; set; }
        [Required]
        public string sexe { get; set; }
        [Required]
        public string adresse { get; set; }
        [Required]
        public string ville { get; set; }
        [Required]
        public string codeP { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string mail { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime dateDeb { get; set; }
        [Required]
        public string typForm { get; set; }
        public string? cobolForm { get; set; }
        public string? objetForm { get; set; }
    
 
    }
}
