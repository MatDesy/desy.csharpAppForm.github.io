using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListFridgeUI
{
    public class Aliment
    {
        #region Champs
        //CHAMPS
        private int m_quantite;
        private decimal m_poids;
        private string m_nomAliment;
        private DateTime m_date;
        public enum AlimentType { solide = 0, liquide = 1};

        private AlimentType m_type = new AlimentType();

        #endregion
        #region Propriétés
        //Propriétés

        //Retourne la quantité de cette aliment
        public int Quantite
        {
            get
            {
                if (m_quantite < 0)
                {
                    throw new ArgumentOutOfRangeException("La quantité est invalide");
                }
                return m_quantite;
            }
        }

        //Retourne le poids d'un seul aliment de ce type

        public decimal Poids
        {
            get
            {
                if (m_poids <= 0)
                {
                    throw new ArgumentOutOfRangeException("Le poids ne peut pas etre ni 0 et ni en-dessous de 0 ");
                }
                return m_poids;
            }
        }

        //Retourne le nom de l'aliment

        public string NomAliment
        {
            get
            {
                if (m_nomAliment.Length == 0 || m_nomAliment == null)
                {
                    throw new ArgumentNullException("Le nom ne peut pas etre null ou ayant une valeur de rien");
                }
                return m_nomAliment;
            }
        }

        // Retourne le type de l'aliment

        public AlimentType TypeAliment
        {
            get
            {
                if (m_type != AlimentType.liquide || m_type != AlimentType.solide)
                {
                    throw new ArgumentOutOfRangeException("Valeur du enutype est invalide");
                }
                return m_type;
            }
        }
        //Retourne la date d'expiration de l'aliment
        public DateTime DateExpiration
        {
            get
            {
                return m_date;
            }
        }

        #endregion
        #region Méthodes et constructeur
        //Constructeur
        public Aliment(string pNomAliment, decimal pPoids, int pQuantite, AlimentType pType, DateTime pDateExpiration)
        {
            m_quantite = pQuantite;
            m_poids = pPoids;
            m_nomAliment = pNomAliment;
            m_type = pType;
            m_date = pDateExpiration;
        }
        //Méthodes
        #endregion
    }
}
