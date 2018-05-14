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
    public partial class frm_selectpatient : Form
    {
       

        public frm_selectpatient()
        {
            InitializeComponent();
        }

        private void frm_selectpatient_Load(object sender, EventArgs e)
        {
            PatientMetier patientmetier=new PatientMetier();
            List<Patient> lst_patients=new List<Patient>();

            lst_patients = patientmetier.selectAllPatients();

            this.dgv_listepatients.DataSource = lst_patients;

           
        }

        private void btn_selectpatient_Click(object sender, EventArgs e)
        {
            int ligne_selected = dgv_listepatients.CurrentCell.RowIndex;

            PatientMetier patientmetier = new PatientMetier();
            List<Patient> lst_patients = new List<Patient>();

            lst_patients = patientmetier.selectAllPatients();

            Patient v_patient_selected = lst_patients[ligne_selected];
            string v_id_patient_selected = v_patient_selected.id_patient;

            frm_envoyerdemande vEnvoyerdemande = new frm_envoyerdemande();

            frm_selectdonneespatient frmSelectdonneespatient = new frm_selectdonneespatient(v_id_patient_selected, vEnvoyerdemande);
            frmSelectdonneespatient.Show();
            this.Hide();

        }

        private void dgv_listepatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
