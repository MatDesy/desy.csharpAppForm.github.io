using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppHopitalUI
{
    public class Patient
    {
        #region Champs
        private int m_idPatient;
        private string m_nom;
        private string m_prenom;
        private string m_NAM;
        public enum EnuGenre { Masculin, Feminin, autre };
        public enum EnuAttente { EnAttente, Encours, EstAssigner, Inactif };
        public enum EnuTypeSang { Aplus, Amoins, ABplus, ABmoins, Bplus, Bmoins, Oplus, Omoins };
        private DateTime m_dateNaissance;
        private string m_adresse;
        private string m_ville;
        private string m_province;
        private string m_codePostal;
        private string m_email;
        private int m_noTelephone;
        private double m_poidsEnKg;
        private double m_tailleEnCM;
        private EnuGenre m_genre;
        private EnuTypeSang m_sangType;
        private string[] m_tabInfoAdresse;
        public const string NOTAVAILABLE = "NAN";
        private EnuAttente m_attente;
        private int m_idMedecin;
        #endregion
        #region Propriétés
        public int IdPatient
        {
            get
            {
                return m_idPatient;
            }
        }
        public int IdMedecin
        {
            get
            {
                return m_idMedecin;
            }
            set
            {
                m_idMedecin = value;
            }
        }
        public string Nom
        {
            get
            {
                if (m_nom == null || m_nom.Length > 16)
                {
                    throw new IndexOutOfRangeException("Le nom est null ou dépasse la limite de 16");
                }

                return m_nom;
            }
        }
        public string Prenom
        {
            get
            {
                if (m_prenom == null || m_prenom.Length > 16)
                {
                    throw new IndexOutOfRangeException("Le prenom est null ou dépasse la limite de 16");
                }

                return m_prenom;
            }
        }
        public string NoAssuranceMaladie
        {
            get
            {
                for (int i = 0; i <= 3; i++)
                {
                    char laLettre = m_NAM[i];

                    if (char.IsNumber(laLettre))
                    {
                        throw new InvalidOperationException("Le numéro d'assurance maladie est invalide");                      
                    }
                }

                return m_NAM;
            }
        }
        public EnuGenre Genre
        {
            get
            {
                return m_genre;
            }
        }
        public EnuTypeSang TypeSang
        {
            get
            {
                return m_sangType;
            }
        }
        public EnuAttente Attente
        {
            get
            {
                return m_attente;
            }
            set
            {
                m_attente = value;
            }
        }
        public DateTime DateNaissance
        {
            get
            {
                if (m_dateNaissance <= DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException("La date de naissance est situé dans le futur");
                }

                return m_dateNaissance;
            }
        }
        public string[] AdresseComplete
        {
            get
            {
                m_tabInfoAdresse = new string[] { m_adresse, m_ville, m_province, m_codePostal };

                for (int i = 0; i < m_tabInfoAdresse.Length - 1; i++)
                {
                    if (m_tabInfoAdresse[i] == null)
                    {
                        m_tabInfoAdresse[i] = NOTAVAILABLE;
                    }
                }
                return m_tabInfoAdresse;
            }
        }
        public string Email
        {
            get
            {
                if (m_email == null)
                {
                    return "NAN";
                }

                return m_email;
            }
        }
        public int NoTelephone
        {
            get
            {
                return m_noTelephone;
            }
        }
        public double PoidsEnKG
        {
            get
            {
                return m_poidsEnKg;
            }
        }
        public double TailleEnCM
        {
            get
            {
                return m_tailleEnCM;
            }
        }
        #endregion
        #region Méthodes et constructeur
        public Patient(int pId, string pNom, string pPrenom, string pNAM, EnuGenre pGenre, EnuTypeSang pSang, DateTime pDateNaissance, string pAdresse, string pVille, string pProvince, string pCodePostal, string pEmail,
            int pTelephone, double pPoids, double pTaille, EnuAttente pAttente, int pIdMedecin)
        {
            m_idPatient = pId;
            m_nom = pNom;
            m_prenom = pPrenom;
            m_NAM = pNAM;
            m_adresse = pAdresse;
            m_ville = pVille;
            m_province = pProvince;
            m_codePostal = pCodePostal;
            m_genre = pGenre;
            m_sangType = pSang;
            m_dateNaissance = pDateNaissance;
            m_email = pEmail;
            m_noTelephone = pTelephone;
            m_poidsEnKg = pPoids;
            m_tailleEnCM = pTaille;
            m_attente = pAttente;
            m_idMedecin = pIdMedecin;
        }
        public bool EstAssigner()
        {
            if (this.m_attente == EnuAttente.EstAssigner)
            {
                return true;
            }
            return false;
        }
        public bool EstEnCours()
        {
            if (this.m_attente == EnuAttente.Encours)
            {
                return true;
            }
            return false;
        }
        public void PatientDevientAssigner()
        {
            if (this.EstAssigner())
            {
                return;
            }
            this.m_attente = EnuAttente.EstAssigner;
        }
        public void PatientDevientEnAttente()
        {
            if (this.m_attente == EnuAttente.EnAttente)
            {
                return;
            }
            this.m_attente = EnuAttente.EnAttente;
        }
        public void PatientDevientInactif()
        {
            if (this.m_attente != EnuAttente.Inactif)
            {
                this.m_attente = EnuAttente.Inactif;
            }
        }
        #endregion
    }
}
