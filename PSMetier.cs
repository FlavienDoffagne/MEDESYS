using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDESYS.ADO;
using MEDESYS.BUSINESS_OBJECTS;

namespace MEDESYS.METIER
{
    public class PSMetier
    {
        private PSADO _psado;

        public PSADO psado
        {
            get { return _psado; }
            set { _psado = value; }
        }

        public PSMetier()
        {
            psado=new PSADO();
        }

        public List<ProfessionnelSante> selectAllPS()
        {
            return psado.selectAll();
        }

        public ProfessionnelSante selectDonneesFromIdPS(string p_id_ps)
        {
            return psado.selectDonneesFromIdPS(p_id_ps);
        }

        public void insertPS(ProfessionnelSante p_ps, string p_id_ps)
        {
            psado.insertPS(p_ps, p_id_ps);
        }

        public void deletePS(ProfessionnelSante p_ps)
        {
            psado.deletePS(p_ps);
        }

        public void updatePS(ProfessionnelSante p_ps)
        {
            psado.updatePS(p_ps);
        }
    }
}
