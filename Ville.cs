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

    public class Ville
    {

        private string _id_ville;

        public string id_ville
        {

            get { return _id_ville; }

            set { _id_ville = value; }
        }

        private string _nom;

        public string nom
        {

            get { return _nom; }

            set { _nom = value; }
        }

        private string _cp;

        public string cp
        {

            get { return _cp; }

            set { _cp = value; }
        }

        private string _id_pays;

        public string id_pays
        {

            get { return _id_pays; }

            set { _id_pays = value; }
        }

        public Ville()
        {

        }

        public Ville(string id_ville, string nom, string cp, string id_pays)
        {
            this.id_ville = id_ville;
            this.nom = nom;
            this.cp = cp;
            this.id_pays = id_pays;

        }
    }
}