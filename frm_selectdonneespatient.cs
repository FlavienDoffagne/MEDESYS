using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEDESYS.BUSINESS_OBJECTS;
using MEDESYS.METIER;
using MEDESYS.OUTILS;

namespace MEDESYS.IHM
{
    public partial class frm_selectdonneespatient : Form
    {
        public string v_id_patient_selected_global;
        public frm_envoyerdemande v_frmenvoyerdemande;

        public frm_selectdonneespatient(string v_id_patient_selected, frm_envoyerdemande vEnvoyerdemande)
        {
            v_id_patient_selected_global = v_id_patient_selected;
            InitializeComponent();
            this.v_frmenvoyerdemande = vEnvoyerdemande;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_selectdonneespatient_Click(object sender, EventArgs e)
        {

            PatientMetier patientmetier = new PatientMetier();
            Patient patient_selected = new Patient();

            patient_selected = patientmetier.selectDonneesFromIdPatient(p_id_patient: v_id_patient_selected_global);


            List<string> lst_datatosend = new List<string>();

            if (chk_nompatient.Checked == true)
            {
                lst_datatosend.Add(item: patient_selected.nom.ToString());
            }
            else
            {
                lst_datatosend.Add(item: null);
            }

            if (chk_prenompatient.Checked == true)
            {
                lst_datatosend.Add(item: patient_selected.prenom.ToString());
            }
            else
            {
                lst_datatosend.Add(item: null);
            }

            if (chk_idnational.Checked == true)
            {
                lst_datatosend.Add(item: patient_selected.id_nat.ToString());
            }
            else
            {
                lst_datatosend.Add(item: null);
            }

            if (chk_ddn.Checked == true)
            {
                lst_datatosend.Add(item: patient_selected.date_naissance.ToString());
            }
            else
            {
                lst_datatosend.Add(item: null);
            }

            if (chk_sexe.Checked == true)
            {
                lst_datatosend.Add(item: patient_selected.sexe.ToString());
            }
            else
            {
                lst_datatosend.Add(item: null);
            }

            if (chk_adressepatient.Checked == true)
            {
                lst_datatosend.Add(item: patient_selected.adresse.ToString());
            }
            else
            {
                lst_datatosend.Add(item: null);
            }

            if (chk_telpatient.Checked == true)
            {
                lst_datatosend.Add(item: patient_selected.tel);
            }
            else
            {
                lst_datatosend.Add(item: null);
            }

            if (chk_mobilepatient.Checked == true)
            {
                lst_datatosend.Add(item: patient_selected.mob);
            }
            else
            {
                lst_datatosend.Add(item: null);
            }

            if (chk_antecedentspatient.Checked == true)
            {
                lst_datatosend.Add(item: patient_selected.antecedents);
            }
            else
            {
                lst_datatosend.Add(item: null);
            }

            string xmlpath;
            OutilsXML outilsXml = new OutilsXML();
            xmlpath = outilsXml.fctGenererXML(p_filename: patient_selected.id_patient + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second, p_lst_datatosend: lst_datatosend);
            
            v_frmenvoyerdemande.updateTextBox(xmlpath);

            if (chk_consultations.Checked == true)
            {
                frm_selectconsultation frmSelectconsultation = new frm_selectconsultation(v_id_patient_selected: v_id_patient_selected_global);
                frmSelectconsultation.ShowDialog();
                this.Close();
            }
            else
            {
                lst_datatosend.Add(item: null);
                this.Close();
            }
        }

        private void frm_selectdonneespatient_Load(object sender, EventArgs e)
        {
            PatientMetier patientmetier = new PatientMetier();
            Patient patient_selected = new Patient();

            patient_selected = patientmetier.selectDonneesFromIdPatient(p_id_patient: v_id_patient_selected_global);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_selectall.Checked == true)
            {
                chk_nompatient.Checked = true;
                chk_prenompatient.Checked = true;
                chk_ddn.Checked = true;
                chk_adressepatient.Checked = true;
                chk_idnational.Checked = true;
                chk_telpatient.Checked = true;
                chk_mobilepatient.Checked = true;
                chk_sexe.Checked = true;
                chk_antecedentspatient.Checked = true;
                chk_consultations.Checked = true;
            }
            else
            {
                chk_nompatient.Checked = false;
                chk_prenompatient.Checked = false;
                chk_ddn.Checked = false;
                chk_adressepatient.Checked = false;
                chk_idnational.Checked = false;
                chk_telpatient.Checked = false;
                chk_mobilepatient.Checked = false;
                chk_sexe.Checked = false;
                chk_antecedentspatient.Checked = false;
                chk_consultations.Checked = false;
            }
           
        }

        private void lbl_nbselect_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            
        }
    }
}

