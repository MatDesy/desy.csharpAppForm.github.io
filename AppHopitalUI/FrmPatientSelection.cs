using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppHopitalUI
{
    public partial class FrmPatientSelection : Form
    {
        Patient m_patientSelectionner;

        public FrmPatientSelection(Patient pPatient)
        {
            InitializeComponent();
            MettreInfoPatient(m_patientSelectionner = pPatient);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            btnClose.Focus();

        }
        private void MettreInfoPatient(Patient pPatient)
        {
            txtnom.Text = pPatient.Nom;
            txtprenom.Text = pPatient.Prenom;
            txtAdresse.Text = pPatient.AdresseComplete[0];
            txtVille.Text = pPatient.AdresseComplete[1];
            txtProvince.Text = pPatient.AdresseComplete[2];
            txtCPostal.Text = pPatient.AdresseComplete[3];
            txtDateNaissance.Text = pPatient.DateNaissance.ToString("yyyy-MM-dd");
            txtEmail.Text = pPatient.Email;
            txtGenre.Text = pPatient.Genre.ToString();
            txtNAM.Text = pPatient.NoAssuranceMaladie;
            txtPoids.Text = pPatient.PoidsEnKG.ToString();
            txtSang.Text = pPatient.TypeSang.ToString();
            txtTelephone.Text = pPatient.NoTelephone.ToString();
            txtTaille.Text = pPatient.TailleEnCM.ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
