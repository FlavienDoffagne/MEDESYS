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
    public class DiagnostiqueMetier
    {
        private DiagnostiqueADO _diagnostiqueado;

        public DiagnostiqueADO diagnostiqueado
        {
            get { return _diagnostiqueado; }
            set { _diagnostiqueado = value; }
        }

        public DiagnostiqueMetier()
        {
            diagnostiqueado = new DiagnostiqueADO();
        }

        public List<Diagnostique> selectAllPatients()
        {
            return diagnostiqueado.selectAll();
        }

        public List<Diagnostique> SelectDiagnostiqueFromIdPatient(string p_id_diagnostique)
        {
            return diagnostiqueado.selectDiagnostiquesFromIdPatient(p_id_diagnostique);
        }

        public void insertPatient(Diagnostique p_diagnostique)
        {
            string p_id_diagnostique = OutilsUUID.generateUUID();

            diagnostiqueado.insertDiagnostique(p_diagnostique, p_id_diagnostique);
        }

        public void deletePatient(Diagnostique p_diagnostique)
        {
            diagnostiqueado.deleteDiagnostique(p_diagnostique);
        }

        public void updatePatient(Diagnostique p_diagnostique)
        {
            diagnostiqueado.updateDiagnostique(p_diagnostique);
        }

    }
}
