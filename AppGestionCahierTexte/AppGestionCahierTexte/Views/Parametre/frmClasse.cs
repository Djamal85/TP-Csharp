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
        private static List<LaClasse> DataSouce;

        private void Effacer()
        {
            lblLibelle.Text = string.Empty;
            //cbbAnneeAcademique.Text = string.Empty;
            cbbAnneeAcademique.DataSource = Shared.FillListOption.fillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember= "Value";
            DgClasse.DataSource = db.LaClasses.ToList();
            lblLibelle.Focus();

            
        }
        public frmClasse()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LaClasse c = new LaClasse();
            c.LibelleClasse = txtLibelle.Text;
            c.IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString());
            db.LaClasses.Add(c);
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
            var c = db.LaClasses.Find(id);
            c.LibelleClasse = txtLibelle.Text;
            c.IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString());
            db.SaveChanges();
            Effacer();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(DgClasse.CurrentRow.Cells[0].Value.ToString());
            var c = db.LaClasses.Find(id);
            db.LaClasses.Remove(c);
            db.SaveChanges();
            Effacer();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            lblLibelle.Text = DgClasse.CurrentRow.Cells[1].Value.ToString();
            cbbAnneeAcademique.SelectedValue = DgClasse.CurrentRow.Cells[2].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var liste = db.LaClasses.ToList();
            if (!string.IsNullOrEmpty(txtRAnnee.Text))
            {
                int? annee = int.Parse(txtRAnnee.Text);
                liste = liste.Where(c => c.IdAnneeAcademique ==annee).ToList();
            }

            if (!string.IsNullOrEmpty(txtRClasse.Text))
            {
                liste = liste.Where(f => f.LibelleClasse.ToUpper().Contains(txtRClasse.Text.ToUpper())).ToList();


            }
            DgClasse.DataSource = liste;
        }
    }
}
