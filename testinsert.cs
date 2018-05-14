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

namespace MEDESYS.IHM
{
    public partial class testinsert : Form
    {
        public testinsert()
        {
            InitializeComponent();
        }

        private void testinsert_Load(object sender, EventArgs e)
        {
            PSMetier psmetier = new PSMetier();
            List<ProfessionnelSante> lst_ps = new List<ProfessionnelSante>();
            lst_ps = psmetier.selectAllPS();

            foreach (ProfessionnelSante professionnelsante in lst_ps)
            {
                this.cmb_id_ps.Items.Add(professionnelsante.id_ps);
            }

            PatientMetier patientmetier = new PatientMetier();
            List<Patient> lst_patient = new List<Patient>();
            lst_patient = patientmetier.selectAllPatients();

            foreach (Patient patient in lst_patient)
            {
                this.cmb_id_ville_residence.Items.Add(patient.id_ville_residence);
                this.cmb_id_ville_naissance.Items.Add(patient.id_ville_naissance);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_insertpatient_Click(object sender, EventArgs e)
        {
            PatientMetier v_patientmetier = new PatientMetier();

            v_patientmetier.insertPatient(txt_nom.Text, txt_prenom.Text, txt_idnat.Text, txt_ddn.Text.ToString(), txt_sexe.Text,
                txt_adresse.Text, txt_tel.Text, txt_mob.Text, txt_antecedents.Text);
        }
    }
}
