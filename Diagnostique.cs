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
    
public class Diagnostique
    {

        private string _id_diagnostique;

        public string id_diagnostique
        {

            get { return _id_diagnostique; }

            set { _id_diagnostique = value; }
        }

        private DateTime _date_diagnostique;

        public DateTime date_diagnostique
        {

            get { return _date_diagnostique; }

            set { _date_diagnostique = value; }
        }

        private string _diagnostique;

        public string diagnostique
        {

            get { return _diagnostique; }

            set { _diagnostique = value; }
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

        public Diagnostique()
        {

        }

        public Diagnostique(string id_diagnostique, DateTime date_diagnostique, string diagnostique, string id_ps, string id_patient)
        {
            this.id_diagnostique = id_diagnostique;
            this.date_diagnostique = date_diagnostique;
            this.diagnostique = diagnostique;
            this.id_ps = id_ps;
            this.id_patient = id_patient;

        }
    }
}