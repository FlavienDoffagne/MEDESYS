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

    public class Demandes_recues
    {

        private string _id_message;

        public string id_message
        {

            get { return _id_message; }

            set { _id_message = value; }
        }

        private string _texte_message;

        public string texte_message
        {

            get { return _texte_message; }

            set { _texte_message = value; }
        }

        private DateTime _date_message;

        public DateTime date_message
        {

            get { return _date_message; }

            set { _date_message = value; }
        }

        private string _xml;

        public string xml
        {

            get { return _xml; }

            set { _xml = value; }
        }

        private string _id_ps_exp;

        public string id_ps_exp
        {

            get { return _id_ps_exp; }

            set { _id_ps_exp = value; }
        }

        private string _id_ps_dest;

        public string id_ps_dest
        {

            get { return _id_ps_dest; }

            set { _id_ps_dest = value; }
        }

        private string _id_demande_recue;

        public string id_demande_recue
        {

            get { return _id_demande_recue; }

            set { _id_demande_recue = value; }
        }

        public Demandes_recues()
        {

        }

        public Demandes_recues(string id_message, string texte_message, DateTime date_message, string xml, string id_ps_exp, string id_ps_dest, string id_demande_recue)
        {
            this.id_message = id_message;
            this.texte_message = texte_message;
            this.date_message = date_message;
            this.xml = xml;
            this.id_ps_exp = id_ps_exp;
            this.id_ps_dest = id_ps_dest;
            this.id_demande_recue = id_demande_recue;

        }
    }
}