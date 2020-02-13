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
    public partial class FrmListePatient : Form
    {
        private List<Patient> m_lstPatient = new List<Patient>();
        private int m_idMedecin;

        public FrmListePatient(int pIdMedecin)
        {
            InitializeComponent();
            m_idMedecin = pIdMedecin;
            m_lstPatient = PeuplerTest1();
            MettrePatientDansTableau();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void MettrePatientDansTableau()
        {
            lsvPatientAssigner.Items.Clear();
            lsvPatientEnAttente.Items.Clear();

            int pos = 0;
            int pos2 = 0;

            foreach (Patient patientlu in m_lstPatient)
            {                  
                if (patientlu.IdMedecin == m_idMedecin)
                {
                    lsvPatientAssigner.Items.Add(patientlu.IdPatient.ToString());
                    lsvPatientAssigner.Items[pos].SubItems.Add(patientlu.Nom);
                    lsvPatientAssigner.Items[pos].SubItems.Add(patientlu.Prenom);
                    lsvPatientAssigner.Items[pos].SubItems.Add(patientlu.NoAssuranceMaladie);
                    lsvPatientAssigner.Items[pos].SubItems.Add(patientlu.Attente.ToString());
                    pos++;

                }
                else if (patientlu.IdMedecin == 0)
                {
                    lsvPatientEnAttente.Items.Add(patientlu.IdPatient.ToString());
                    lsvPatientEnAttente.Items[pos2].SubItems.Add(patientlu.Nom);
                    lsvPatientEnAttente.Items[pos2].SubItems.Add(patientlu.Prenom);
                    lsvPatientEnAttente.Items[pos2].SubItems.Add(patientlu.NoAssuranceMaladie);
                    lsvPatientEnAttente.Items[pos2].SubItems.Add(patientlu.Attente.ToString());
                    pos2++;
                }
            }
        }

        private void btnDevenirActif_Click(object sender, EventArgs e)
        {
            if (lsvPatientEnAttente.SelectedItems.Count == 0)
            {
                return;
            }

            foreach (Patient patientlu in m_lstPatient)
            {
                if (int.Parse(lsvPatientEnAttente.SelectedItems[0].Text) == patientlu.IdPatient)
                {
                    patientlu.IdMedecin = m_idMedecin;
                    patientlu.PatientDevientAssigner();
                    MettrePatientDansTableau();
                    return;
                }
            }
        }

        private void btnEnleverPatient_Click(object sender, EventArgs e)
        {
            if (lsvPatientAssigner.SelectedIndices.Count == 0)
            {
                return;
            }

            foreach (Patient patientlu in m_lstPatient)
            {
                if (int.Parse(lsvPatientAssigner.SelectedItems[0].Text) == patientlu.IdPatient)
                {
                    patientlu.IdMedecin = 0;
                    patientlu.PatientDevientEnAttente();
                    MettrePatientDansTableau();
                    return;
                }
            }
        }

        private void btnTerminerPatient_Click(object sender, EventArgs e)
        {
            if (lsvPatientAssigner.SelectedIndices.Count == -1)
            {
                return;
            }

            foreach (Patient patientlu in m_lstPatient)
            {
                if (lsvPatientAssigner.SelectedItems.Count == 0)
                {
                    return;
                }
                if (int.Parse(lsvPatientAssigner.SelectedItems[0].Text) == patientlu.IdPatient)
                {
                    patientlu.PatientDevientInactif();
                    MettrePatientDansTableau();
                    return;
                }
            }
        }
        private void btnEncours_Click(object sender, EventArgs e)
        {
            if (lsvPatientAssigner.SelectedIndices.Count > 0)
            {
                foreach (Patient patientlu in m_lstPatient)
                {
                    if (int.Parse(lsvPatientAssigner.SelectedItems[0].Text) == patientlu.IdPatient)
                    {
                        if (patientlu.EstEnCours())
                        {
                            return;
                        }
                        //m_lstPatient.Where(p => p.EstEnCours()) ;

                        foreach (Patient patient in m_lstPatient)
                        {
                            if (patient.EstEnCours())
                            {
                                patient.PatientDevientAssigner();
                            }
                        }

                        patientlu.Attente = Patient.EnuAttente.Encours;
                        MettrePatientDansTableau();
                        return;
                    }
                }
            }
            //if (lsvPatientEnAttente.SelectedIndices.Count > 0)
            //{
            //    foreach (Patient patientlu in m_lstPatient)
            //    {
            //        if (int.Parse(lsvPatientEnAttente.SelectedItems[0].Text) == patientlu.IdPatient)
            //        {
            //            if (patientlu.EstEnCours())
            //            {
            //                return;
            //            }
            //            m_lstPatient.ForEach(p => p.PatientDevientAssigner());
            //            patientlu.Attente = Patient.EnuAttente.Encours;
            //            MettrePatientDansTableau();
            //            return;
            //        }
            //    }
            //}
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<Patient> PeuplerTest1()
        {
            Random rdm = new Random();

            List<Patient> lstTest = new List<Patient>();

            for (int i = 0; i < 20; i++)
            {
                Patient pTest = new Patient(rdm.Next(1, 9999999), "nomtest" + i.ToString(), "prenomtest" + i.ToString(), "test" + rdm.Next(10000000, 99999999).ToString(), (Patient.EnuGenre)rdm.Next(0, 3)
                    , (Patient.EnuTypeSang)rdm.Next(0, 8), DateTime.Now.AddDays(5), "test rue " + i.ToString(), "testVille " + i.ToString(), "testProvince " + rdm.Next(0, 201).ToString(), "j6w 2q"
                    + i.ToString(), "test@"+ i.ToString() + rdm.Next(0,1000) +".com", (int.Parse("450") + rdm.Next(1111111, 9999998)), 45.60, 167.45, Patient.EnuAttente.EnAttente, 0);

                lstTest.Add(pTest);
            }
            for (int i = 0; i < 8; i++)
            {
                Patient pTest = new Patient(rdm.Next(1, 9999999), "nomtest" + i.ToString(), "prenomtest" + i.ToString(), "test" + rdm.Next(10000000, 99999999).ToString(), (Patient.EnuGenre)rdm.Next(0, 3)
                    , (Patient.EnuTypeSang)rdm.Next(0, 8), DateTime.Now.AddDays(5), "test rue " + i.ToString(), "testVille " + i.ToString(), "testProvince " + rdm.Next(0, 201).ToString(), "j6w 2q"
                    + i.ToString(), "test@" + i.ToString() + rdm.Next(0, 1000) + ".com", (int.Parse("450") + rdm.Next(1111111, 9999998)), 45.60, 167.45, (Patient.EnuAttente)rdm.Next(2, 4), 5000);

                lstTest.Add(pTest);
            }

            return lstTest;
        }
        private void lsvPatientAssigner_DoubleClick(object sender, EventArgs e)

        {
            if (lsvPatientAssigner.SelectedItems.Count > 0)
            {
               Patient PatientSelection = m_lstPatient.Where(p => p.IdPatient == int.Parse(lsvPatientAssigner.SelectedItems[0].Text)).First();

                FrmPatientSelection frmSlct = new FrmPatientSelection(PatientSelection);

                frmSlct.ShowDialog();
            }
        }
    }
}
