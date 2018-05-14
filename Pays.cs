using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MEDESYS.BUSINESS_OBJECTS
{

    public class Pays
    {

        private string _id_pays;

        public string id_pays
        {

            get { return _id_pays; }

            set { _id_pays = value; }
        }

        private string _nom;

        public string nom
        {

            get { return _nom; }

            set { _nom = value; }
        }

        public Pays()
        {

        }

        public Pays(string id_pays, string nom)
        {
            this.id_pays = id_pays;
            this.nom = nom;

        }
    }
}