using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionLocationEtudiants.Model;

namespace GestionLocationEtudiants.View
{
    public partial class frmProprietaire : Form
    {
        public frmProprietaire()
        {
            InitializeComponent();
        }
        BdAppartementContext db = new BdAppartementContext();

        private void ResetForm()
        {
            txtCni.Text = string.Empty;
            txtNomPrenom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNinea.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtRccm.Text = string.Empty;
            //dgProprietaire.DataSource = db.proprietaires.ToList();
            dgProprietaire.DataSource = db.proprietaires.Select(a => new { a.IdPersonne, a.NomPrenom, a.Telephone, a.Email, a.CNI, a.Ninea, a.Rccm }).ToList();

            txtNomPrenom.Focus();


        }
       
        

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Proprietaire p = new Proprietaire();
            p.NomPrenom = txtNomPrenom.Text;
            p.Email = txtEmail.Text;
            p.Telephone = txtTelephone.Text;
            p.CNI = txtCni.Text;
            p.Rccm = txtRccm.Text;
            p.Ninea = txtNinea.Text;

            db.proprietaires.Add(p);
            db.SaveChanges();
            ResetForm();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProprietaire.CurrentRow.Cells[0].Value.ToString());
            var p = db.proprietaires.Find(id);
            p.NomPrenom = txtNomPrenom.Text;
            p.Email = txtEmail.Text;
            p.Telephone = txtTelephone.Text;
            p.CNI = txtCni.Text;
            p.Rccm = txtRccm.Text;
            p.Ninea = txtNinea.Text;

            db.SaveChanges();
            ResetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProprietaire.CurrentRow.Cells[0].Value.ToString());
            var p = db.proprietaires.Find(id);
            db.proprietaires.Remove(p);
            db.SaveChanges();
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNomPrenom.Text = dgProprietaire.CurrentRow.Cells[1].Value.ToString();
            txtTelephone.Text = dgProprietaire.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgProprietaire.CurrentRow.Cells[3].Value.ToString();
            txtCni.Text = dgProprietaire.CurrentRow.Cells[4].Value.ToString();
            txtNinea.Text = dgProprietaire.CurrentRow.Cells[5].Value.ToString();
            txtRccm.Text = dgProprietaire.CurrentRow.Cells[6].Value.ToString();

        }

        private void frmProprietaire_Load_1(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
