using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDESYS.BUSINESS_OBJECTS;
using MEDESYS.ADO;

namespace MEDESYS.METIER
{
    public class Demandes_envoyeesMetier
    {

        private Demandes_envoyeesADO _demande_envoyeeado;

        public Demandes_envoyeesADO demande_envoyeeado
        {
            get { return _demande_envoyeeado; }
            set { _demande_envoyeeado = value; }
        }

        public Demandes_envoyeesMetier()
        {
            demande_envoyeeado = new Demandes_envoyeesADO();
        }

        public List<Demandes_envoyees> selectAll()
        {
            return demande_envoyeeado.selectAll();
        }

        public Demandes_envoyees selectDemandeEnvoyeeById(String p_id_demande_envoyee )
        {
            return demande_envoyeeado.selectDonneesFromIdDemandeEnvoyee(p_id_demande_envoyee);
        }

        public string insertDemandeEnvoyee(Demandes_envoyees p_demande_envoyee)
        {
            return demande_envoyeeado.insertDemandeEnvoyee(p_demande_envoyee);
        }

        public string deleteDemandeEnvoyee(Demandes_envoyees p_demande_envoyee)
        {
            return demande_envoyeeado.deleteDemandeEnvoyee(p_demande_envoyee);
        }

    }
}
