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

    public class Patient
    {

        private string _id_patient;

        public string id_patient
        {

            get { return _id_patient; }

            set { _id_patient = value; }
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

        private string _id_nat;

        public string id_nat
        {

            get { return _id_nat; }

            set { _id_nat = value; }
        }

        private DateTime _date_naissance;

        public DateTime date_naissance
        {

            get { return _date_naissance; }

            set { _date_naissance = value; }
        }

        private string _sexe;

        public string sexe
        {

            get { return _sexe; }

            set { _sexe = value; }
        }

        private string _adresse;

        public string adresse
        {

            get { return _adresse; }

            set { _adresse = value; }
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

        private string _antecedents;

        public string antecedents
        {

            get { return _antecedents; }

            set { _antecedents = value; }
        }

        private string _id_ps;

        public string id_ps
        {

            get { return _id_ps; }

            set { _id_ps = value; }
        }

        private string _id_ville_residence;

        public string id_ville_residence
        {

            get { return _id_ville_residence; }

            set { _id_ville_residence = value; }
        }

        private string _id_ville_naissance;

        public string id_ville_naissance
        {

            get { return _id_ville_naissance; }

            set { _id_ville_naissance = value; }
        }

        public Patient()
        {

        }

        public Patient(string id_patient, string nom, string prenom, string id_nat, DateTime date_naissance, string sexe, string adresse, string tel, string mob, string antecedents, string id_ps, string id_ville_residence, string id_ville_naissance)
        {
            this.id_patient = id_patient;
            this.nom = nom;
            this.prenom = prenom;
            this.id_nat = id_nat;
            this.date_naissance = date_naissance;
            this.sexe = sexe;
            this.adresse = adresse;
            this.tel = tel;
            this.mob = mob;
            this.antecedents = antecedents;
            this.id_ps = id_ps;
            this.id_ville_residence = id_ville_residence;
            this.id_ville_naissance = id_ville_naissance;

        }
    }
}