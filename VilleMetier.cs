using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDESYS.ADO;
using MEDESYS.BUSINESS_OBJECTS;

namespace MEDESYS.METIER
{
    public class VilleMetier
    {

        private VilleADO _villeado;

        public VilleADO villeado
        {
            get { return _villeado; }
            set { _villeado = value; }
        }

        public VilleMetier()
        {
            villeado = new VilleADO();
        }

        public List<Ville> selectAll()
        {
            return villeado.selectAll();
        }

        public Ville selectVilleFromIdPatient(String p_id_patient)
        {
            return villeado.selectVilleFromIdPatient(p_id_patient);
        }

    }
}
