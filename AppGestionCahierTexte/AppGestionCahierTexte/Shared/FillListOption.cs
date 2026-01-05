using AppGestionCahierTexte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Shared
{
    public static class FillListOption
    {
        static BdCahierTexteContext db = new BdCahierTexteContext();
        public static List<ListItem> fillAnneeAcademique()
        {
            List<ListItem> laliste = new List<ListItem>();
            var liste = db.AnneesAcademiques.ToList();
            laliste.Add(new ListItem
            {
                Value = null,
                Text = "Selectionner"
            });
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.ValueAnneeAcademique.ToString(),
                    Text = t.LibelleAnneeAcademique.ToString()
                };
                laliste.Add(item);
            }
            return laliste;
        }
    }
}
