using AppGestionCahierTexte.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCahierTexte.Views.Parametre
{
    public partial class frmClasse : Form
    {
        BdCahierTexteContext db = new BdCahierTexteContext();
        private static List<Classe> DataSouce;

        private void Effacer()
        {
            TxtLibelle.Text = string.Empty;
            cbbAnneeAcademique.Text = string.Empty;
            cbbAnneeAcademique.DataSource = db.AnneesAcademiques.ToList();
            cbbAnneeAcademique.Text = "LibelleAnneeAcademique";
            cbbAnneeAcademique.ValueMember= "ValueAnneeAcademique";
            DgClasse.DataSource = db.Classes.ToList();
            TxtLibelle.Focus();

            
        }
        public frmClasse()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Classe c = new Classe();
            c.LibelleClasse = TxtLibelle.Text;
            c.IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString());
            db.Classes.Add(c);
            db.SaveChanges();
            Effacer();


        }

        private void frmClasse_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(DgClasse.CurrentRow.Cells[0].Value.ToString());
            var c = db.Classes.Find(id);
            c.LibelleClasse = TxtLibelle.Text;
            c.IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString());
            db.SaveChanges();
            Effacer();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(DgClasse.CurrentRow.Cells[0].Value.ToString());
            var c = db.Classes.Find(id);
            db.Classes.Remove(c);
            db.SaveChanges();
            Effacer();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            TxtLibelle.Text = DgClasse.CurrentRow.Cells[1].Value.ToString();
            cbbAnneeAcademique.SelectedValue = DgClasse.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
