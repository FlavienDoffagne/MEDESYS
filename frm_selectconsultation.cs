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
    public partial class frm_selectconsultation : Form
    {
        public string v_id_patient_selected_global;

        public frm_selectconsultation(string v_id_patient_selected)
        {
            v_id_patient_selected_global = v_id_patient_selected;
            InitializeComponent();
        }

        
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_selectconsultation_Load(object sender, EventArgs e)
        {
            ConsultationMetier consultationmetier = new ConsultationMetier();
            List<Consultation> lst_consultations = new List<Consultation>();

            lst_consultations = consultationmetier.selectConsultationFromIdPatient(v_id_patient_selected_global);

            this.dgv_listeconsultations.DataSource = lst_consultations;
        }

        private void dgv_listeconsultations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_selectpatient_Click(object sender, EventArgs e)
        {
            List<Consultation> lst_consultationstosend = new List<Consultation>();

            foreach (DataGridViewRow row in dgv_listeconsultations.SelectedRows)
            {
                lst_consultationstosend.Add(row.DataBoundItem as Consultation);
            }

            OutilsXML outilsXml = new OutilsXML();
            outilsXml.fct_addtxtXML(v_id_patient_selected_global, lst_consultationstosend);

            this.Close();
            
        }

        private void lbl_infos_Click(object sender, EventArgs e)
        {

        }
    }
}
