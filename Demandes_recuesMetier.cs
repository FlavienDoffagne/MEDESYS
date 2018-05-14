using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDESYS.BUSINESS_OBJECTS;
using MEDESYS.ADO;

namespace MEDESYS.METIER
{
    class Demandes_recuesMetier
    {
        private Demandes_recuesADO _demande_recueado;

        public Demandes_recuesADO demande_recueado
        {
            get { return _demande_recueado; }
            set { _demande_recueado = value; }
        }

        public Demandes_recuesMetier()
        {
            demande_recueado = new Demandes_recuesADO();
        }

        public List<Demandes_recues> selectAll()
        {
            return demande_recueado.selectAll();
        }

        public Demandes_recues selectDemandeRecueById(String p_id_demande_recue)
        {
            return demande_recueado.selectDonneesFromIdDemandeRecue(p_id_demande_recue);
        }

        public string insertDemandeRecue(Demandes_recues p_demande_recue)
        {
            return demande_recueado.insertDemandeRecue(p_demande_recue);
        }

        public string deleteDemandeRecue(Demandes_recues p_demande_recue)
        {
            return demande_recueado.deleteDemandeRecue(p_demande_recue);
        }

    }
}
