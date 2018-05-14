using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDESYS.BUSINESS_OBJECTS
{
    public class ProfessionnelSante
    {

        private string _id_ps;
        public string id_ps
        {
            get { return _id_ps; }
            set { _id_ps = value; }
        }

        private string _nom;
        public string nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private string _prenom;
        public string prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        private string _ins;
        public string ins
        {
            get { return _ins; }
            set { _ins = value; }
        }

        private string _tel;
        public string tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        private string _mob;
        public string mob
        {
            get { return _mob; }
            set { _mob = value; }
        }

        private string _adresse;
        public string adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        private string _mail;
        public string mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        private string _fax;
        public string fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        private string _id_ville;
        public string id_ville
        {
            get { return _id_ville; }
            set { _id_ville = value; }
        }

        public enum Categories { traitant, specialiste, infirmier, secretaire };

        private Categories _categorie;
        public Categories categorie
        {
            get { return _categorie; }
        }


        public enum Specialites { cardiologue, orl, dentiste };

        private Specialites _specialite;
        public Specialites specialite
        {
            get { return _specialite; }
        }
    }

}

