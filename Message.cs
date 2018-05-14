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

    public class Message
    {

        private string _id_message;

        public string id_message
        {

            get { return _id_message; }

            set { _id_message = value; }
        }

        private DateTime _date_message;

        public DateTime date_message
        {

            get { return _date_message; }

            set { _date_message = value; }
        }

        private bool _recu;

        public bool recu
        {

            get { return _recu; }

            set { _recu = value; }
        }

        private string _txt_message;

        public string txt_message
        {

            get { return _txt_message; }

            set { _txt_message = value; }
        }

        private string _xml;

        public string xml
        {

            get { return _xml; }

            set { _xml = value; }
        }

        private string _id_demande;

        public string id_demande
        {

            get { return _id_demande; }

            set { _id_demande = value; }
        }

        private string _id_dest;

        public string id_dest
        {

            get { return _id_dest; }

            set { _id_dest = value; }
        }

        private string _id_exp;

        public string id_exp
        {

            get { return _id_exp; }

            set { _id_exp = value; }
        }

        public Message()
        {

        }

        public Message(string id_message, DateTime date_message, bool recu, string txt_message, string xml, string id_demande, string id_dest, string id_exp)
        {
            this.id_message = id_message;
            this.date_message = date_message;
            this.recu = recu;
            this.txt_message = txt_message;
            this.xml = xml;
            this.id_demande = id_demande;
            this.id_dest = id_dest;
            this.id_exp = id_exp;

        }
    }
}
