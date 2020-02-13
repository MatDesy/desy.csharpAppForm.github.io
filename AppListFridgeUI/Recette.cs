using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListFridgeUI
{
    public class Recette
    {
        #region Champs
        //CHAMPS

        private List<Aliment> m_lstAlimentBesoin = new List<Aliment>();
        private string m_recette;
        #endregion
        #region Propriétés
        public string NomRecette
        {
            get
            {
                return m_recette;
            }
        }
        //Propriétés
        #endregion
        #region Méthodes et constructeur
        //Constructeur
        public Recette(string pRecette, List<Aliment> pLstAliment)
        {
            m_recette = pRecette;
            m_lstAlimentBesoin = pLstAliment;
        }
        //Méthodes
        #endregion
    }
}
