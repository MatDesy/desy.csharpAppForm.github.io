using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppScolaireUI
{
    public class Etudiant
    {
        #region Champs
        #endregion

        // Champs

        public enum enuSexe { Homme, Femme, Autre };

        private int m_idEtudiant;
        private double m_CoteR;
        private string m_nom;
        private string m_prenom;
        private DateTime m_dateNaissance;
        private List<Cours> m_lstCours;
        private int m_age;
        private enuSexe m_sexe;
        private bool m_actif;
        private Programme m_programme;
        private long m_NoTelephone;
        private string m_adresse;

        #region Propriété

        // Propriété

        //RETOURNE LE GENRE DE L'ÉTUDIANT
        public enuSexe Sexe
        {
            get
            {
                return m_sexe;
            }
        }

        //RETOURNE L'ID DE L'ÉTUDIANT

        public int ID
        {
            get
            {
                return m_idEtudiant;
            }
        }

        //RETOURNE LA COTE R DE L'ÉTUDIANT
        public double CoteR
        {
            get
            {
                return m_CoteR;
            }
        }

        //RETOURNE LE NOM DE L'ÉTUDIANT
        public string Nom
        {
            get
            {
                return m_nom;
            }
        }

        //RETOURNE LE PRÉNOM DE L'ÉTUDIANT
        public string Prenom
        {
            get
            {
                return m_prenom;
            }
        }

        //RETOURNE LE NOM COMPLET DE L'ÉTUDIANT
        public string NomComplet
        {
            get
            {
                return m_nom + ',' + m_prenom;
            }
        }

        public DateTime DateNaissance
        {
            get
            {
                return m_dateNaissance;
            }
        }

        //RETOURNE L'AGE DE L'ÉTUDIANT
        public int Age
        {
            get
            {
                return m_age;
            }
        }

        //RETOURNE LA LISTE DES COURS DE L'ÉTUDIANT
        public List<Cours> ListeCours
        {
            get
            {
                return m_lstCours;
            }
        }

        //RETOURNE LE TYPE DE PROGRAMME DONT L'ÉTUDIANT EST ASSOCIÉ AVEC
        public Programme ProgrammeEtudiant
        {
            get
            {
                return m_programme;
            }
        }

        //RETOURNE LE NUMÉRO DE TÉLÉPHONE DE L'ÉTUDIANT
        public string NoTelephone
        {
            get
            {
                string TelephoneChaine = m_NoTelephone.ToString();
                string Ext1 = "";
                string Ext2 = "";
                string Ext3 = "";

                int index = 0;

                while (index < 3)
                {
                    Ext1 += TelephoneChaine[index];
                    index++;
                }
                while (index >= 3 && index < 6)
                {
                    Ext2 += TelephoneChaine[index];
                    index++;
                }
                while (index < TelephoneChaine.Length)
                {
                    Ext3 += TelephoneChaine[index];
                    index++;
                }

                return Ext1 + '-' + Ext2 + '-' + Ext3;

            }
        }

        //RETOURNE L'ADRESSE DE L'ÉTUDIANT
        public string Adresse
        {
            get
            {
                return m_adresse;
            }
        }

        #endregion

        #region Méthode et constructeur

        public Etudiant(int pID, enuSexe pSexe, double pCoteR, string pNom, string pPrenom, DateTime pDateNaissance, int pAge, List<Cours> pLstCours, Programme pProgramme, long pNoTelephone, string pAdresse)
        {
            m_idEtudiant = pID;
            m_sexe = pSexe;
            m_CoteR = pCoteR;
            m_nom = pNom;
            m_prenom = pPrenom;
            m_dateNaissance = pDateNaissance;
            m_age = pAge;
            m_lstCours = pLstCours;
            m_programme = pProgramme;
            m_actif = true;
            m_NoTelephone = pNoTelephone;
            m_adresse = pAdresse;
        }

        //RETOURNE SI VRAI OU FAUX L'ÉTUDIANT EST ACTIF
        public bool EstActif()
        {
            return m_actif;
        }
        
        //MET L'ÉTUDIANT INACTIF
        public void DevientInactif()
        {
            m_actif = false;
        }
        public void DevientActif()
        {
            m_actif = true;
        }

        #endregion
    }
}
