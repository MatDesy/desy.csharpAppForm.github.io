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

namespace AppListFridgeUI
{
    public partial class AppForm : Form
    {
        private List<Aliment> m_lstAliment = new List<Aliment>();
        private List<Recette> m_lstRecette = new List<Recette>();

        public AppForm()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                Aliment ajoutAliment = new Aliment("test" + i.ToString(), i + (decimal)0.4, i, Aliment.AlimentType.liquide, DateTime.Today.AddDays(20 + i));

                m_lstAliment.Add(ajoutAliment);
            }
        }

        private void BtnRecipe_Click(object sender, EventArgs e)
        {
            AppFormRecette frmRecette = new AppFormRecette(m_lstAliment, m_lstRecette);

            frmRecette.ShowDialog();
        }

        private void BtnContent_Click(object sender, EventArgs e)
        {
            AppFormAliment frmAliment = new AppFormAliment(m_lstAliment);

            frmAliment.ShowDialog();
        }
    }
}
