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
    public class ConsultationMetier
    {
        private ConsultationADO _consultationado;

        public ConsultationADO consultationado
        {
            get { return _consultationado; }
            set { _consultationado = value; }
        }

        public ConsultationMetier()
        {
            consultationado = new ConsultationADO();
        }

        public List<Consultation> selectAllConsultations()
        {
            return consultationado.selectAll();
        }

        public List<Consultation> selectConsultationFromIdPatient(string p_id_patient)
        {
            return consultationado.selectConsultationsFromIdPatient(p_id_patient);
        }

        public void insertConsultation(Consultation p_consultation)
        {
            string p_id_consult = OutilsUUID.generateUUID();

            consultationado.insertConsultation(p_consultation, p_id_consult);
        }

        public void deleteConsultation(string p_id_consult)
        {
            consultationado.deleteConsultation(p_id_consult);
        }

        public void updateConsultation(Consultation p_consultation)
        {
            consultationado.updateConsultation(p_consultation);
        }
    }
}
