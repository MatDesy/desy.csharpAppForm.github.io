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
    public partial class Form1 : Form
    {
        private string m_idMedecin;
        private string m_motdepasse;

        private SqlConnection BD = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            m_idMedecin = txtId.Text;
            m_motdepasse = txtMdp.Text;
            ErrorProvider error = new ErrorProvider();

            if (txtId.Text.Length == 0)
            {
                error.SetError(txtId, "Mauvais ID");
            }
            if (txtMdp.Text.Length == 0)
            {
                error.SetError(txtMdp, "Mauvais Mot de passe");
            }
            else
            {
                error.Clear();

                FrmListePatient frmlst = new FrmListePatient(int.Parse(m_idMedecin));
                frmlst.ShowDialog();
            }
        }   
    }
}
