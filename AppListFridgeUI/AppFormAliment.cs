using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppListFridgeUI
{
    public partial class AppFormAliment : Form
    {
        private List<Aliment> m_lstAliment = new List<Aliment>();

        public AppFormAliment(List<Aliment> plstAliment)
        {
            InitializeComponent();

            m_lstAliment = plstAliment;
            RemplirLeTableau(m_lstAliment);

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void RemplirLeTableau(List<Aliment> plstAliment)
        {
            int val = 0;

            foreach (Aliment item in plstAliment)
            {
                lsvAliment.Items.Add(item.NomAliment);
                lsvAliment.Items[val].SubItems.Add(item.Poids.ToString());
                lsvAliment.Items[val].SubItems.Add(item.Quantite.ToString());
                lsvAliment.Items[val].SubItems.Add((item.DateExpiration).ToString("yyyy-MM-dd"));

                val++;
            }
        }
    }
}
