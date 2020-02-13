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
    public partial class AppFormRecette : Form
    {
        #region Champs
        //Champs

        private List<Aliment> m_lstAliment = new List<Aliment>();
        private List<Recette> m_lstRecette = new List<Recette>();
        #endregion
        #region Propriétés
            //Propriétés
        #endregion
        #region Init
        public AppFormRecette(List<Aliment> pLstAliment, List<Recette> pLstRecette)
        {
            InitializeComponent();

            m_lstAliment = pLstAliment;
            m_lstRecette = pLstRecette;

        }
        #endregion
        #region Constructeur et méthodes
        #endregion
    }
}
