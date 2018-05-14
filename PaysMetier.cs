using System.Collections.Generic;
using MEDESYS.ADO;
using MEDESYS.BUSINESS_OBJECTS;

namespace MEDESYS.METIER
{


    public class PaysMetier
    {

        private PaysADO _paysado;

        public PaysADO paysado
        {
            get { return _paysado; }
            set { _paysado = value; }
        }

        public PaysMetier()
        {
            paysado = new PaysADO();
        }

        public List<Pays> selectAllPays()
        {
            return paysado.selectAll();
        }

        public Pays selectDonneesFromIdPays (string p_id_pays)
        {
            return paysado.selectDonneesFromIdPays(p_id_pays);
        }

        public string insertPays(string p_id_pays, string p_nom)
        {
            return paysado.insertPays(p_id_pays, p_nom);
        }
    }
}
