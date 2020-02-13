using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppScolaireUI
{
    public partial class Form1 : Form
    {

        SqlConnection sqlBD = new SqlConnection();

        private int m_id;
        private string m_mdp;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            if (txtID.Text == m_id.ToString() && txtMdp.Text == m_mdp)
            {
                FrmChoixVue frmNew = new FrmChoixVue();

                frmNew.ShowDialog();
            }
        }
    }
}
