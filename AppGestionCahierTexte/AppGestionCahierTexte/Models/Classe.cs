using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Models
{
    public class LaClasse
    {
        [Key]
        public int IdClasse { get; set; }

        [MaxLength(10)]
        public string LibelleClasse { get; set; } 
        
        public int? IdAnneAcademique { get; set; }

        public int? IdAcademique { get; set; }


        //[ForeignKey("IdAcademique")]
        //public virtual AnneeAcademique AnneeAcademique { get; set; }
    }
}
