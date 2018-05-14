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

    public class Consultation
    {

        private string _id_consult;

        public string id_consult
        {

            get { return _id_consult; }

            set { _id_consult = value; }
        }

        private DateTime _date_consultation;

        public DateTime date_consultation
        {

            get { return _date_consultation; }

            set { _date_consultation = value; }
        }

        private string _foyer;

        public string foyer
        {

            get { return _foyer; }

            set { _foyer = value; }
        }

        private string _phono;

        public string phono
        {

            get { return _phono; }

            set { _phono = value; }
        }

        private string _ecg;

        public string ecg
        {

            get { return _ecg; }

            set { _ecg = value; }
        }

        private double _poids;

        public double poids
        {

            get { return _poids; }

            set { _poids = value; }
        }

        private double _pression;

        public double pression
        {

            get { return _pression; }

            set { _pression = value; }
        }

        private double _pression_arterielle_systolique;

        public double pression_arterielle_systolique
        {

            get { return _pression_arterielle_systolique; }

            set { _pression_arterielle_systolique = value; }
        }

        private double _pression_arterielle_diastolique;

        public double pression_arterielle_diastolique
        {

            get { return _pression_arterielle_diastolique; }

            set { _pression_arterielle_diastolique = value; }
        }

        private string _obeservation;

        public string obeservation
        {

            get { return _obeservation; }

            set { obeservation = value; }
        }


        private string _id_ps;

        public string id_ps
        {

            get { return _id_ps; }

            set { _id_ps = value; }
        }

        private string _id_patient;

        public string id_patient
        {

            get { return _id_patient; }

            set { _id_patient = value; }
        }


        public Consultation()
        {

        }

        public Consultation(string id_consult, DateTime date_consultation, string foyer, string phono, string ecg, double poids, double pression, double pression_arterielle_systolique, double pression_arterielle_diastolique, string obeservation, string id_ps, string id_patient)
        {
            this.id_consult = id_consult;
            this.date_consultation = date_consultation;
            this.foyer = foyer;
            this.phono = phono;
            this.ecg = ecg;
            this.poids = poids;
            this.pression = pression;
            this.pression_arterielle_systolique = pression_arterielle_systolique;
            this.pression_arterielle_diastolique = pression_arterielle_diastolique;
            this.obeservation = obeservation;
            this.id_ps = id_ps;
            this.id_patient = id_patient;

        }
    }
}