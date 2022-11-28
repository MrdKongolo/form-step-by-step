using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingStepByStep
{
    public partial class frmEnregistrementAbonne : Form
    {
        AbonnesEntities ab;
        public frmEnregistrementAbonne()
        {
            InitializeComponent();
        }

        private void frmEnregistrementAbonne_Load(object sender, EventArgs e)
        {
            ab = new AbonnesEntities();
            ab.Configuration.ProxyCreationEnabled = false;
            ab.Configuration.LazyLoadingEnabled = false;
            abonneBindingSource.DataSource = ab.Abonnes.ToList();
            panelIdentite.BringToFront();
            panelIdentite.Enabled = false;
            Nettoyer();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            panelIdentite.Enabled = true;
            cboDesignation.Focus();
            ab = new AbonnesEntities();
            Abonne a = new Abonne();
            ab.Abonnes.Add(a);
            abonneBindingSource.Add(a);
            abonneBindingSource.MoveLast();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            panelIdentite.Hide();
            panelAdresse.BringToFront();
        }

        private async void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                abonneBindingSource.EndEdit();
                await ab.SaveChangesAsync();

                MessageBox.Show("Bien enregistré !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelIdentite.Show();
                panelIdentite.BringToFront();
                panelIdentite.Enabled = false;
                Nettoyer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de saisie", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                panelIdentite.BringToFront();
                Nettoyer();
            }
        }

        private void Nettoyer()
        {
            cboDesignation.Text = null;
            txtPhone.Text = null;
            txtPrenom.Text = null;
            txtNom.Text = null;
            txtCarteID.Text = null;
            cboType.Text = null;
        }
    }
}
