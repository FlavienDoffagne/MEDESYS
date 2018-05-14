using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDESYS.ADO;
using MEDESYS.BUSINESS_OBJECTS;
using MEDESYS.OUTILS;

namespace MEDESYS.METIER
{
    public class PatientMetier
    {
        private PatientADO _patientado;

        public PatientADO patientado
        {
            get { return _patientado; }
            set { _patientado = value; }
        }

        public PatientMetier()
        {
            patientado = new PatientADO();
        }

        public List<Patient> selectAllPatients()
        {
            return patientado.selectAll();
        }

        public Patient selectDonneesFromIdPatient(string p_id_patient)
        {
            return patientado.selectDonneesFromIdPatient(p_id_patient);
        }

        public void insertPatient(Patient p_patient)
        {
            string p_id_patient = OutilsUUID.generateUUID();

            patientado.insertPatient(p_patient, p_id_patient);
        }

        public void deletePatient(Patient p_patient)
        {
            patientado.deletePatient(p_patient);
        }

        public void updatePatient(Patient p_patient)
        {
            patientado.updatePatient(p_patient);
        }
    }
}
