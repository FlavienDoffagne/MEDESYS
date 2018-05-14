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

    public class Users
    {

        private string _id_user;

        public string id_user
        {

            get { return _id_user; }

            set { _id_user = value; }
        }

        private string _login;

        public string login
        {

            get { return _login; }

            set { _login = value; }
        }

        private string _mdp;

        public string mdp
        {

            get { return _mdp; }

            set { _mdp = value; }
        }

        private bool _admin;

        public bool admin
        {

            get { return _admin; }

            set { _admin = value; }
        }

        private string _id_ps;

        public string id_ps
        {

            get { return _id_ps; }

            set { _id_ps = value; }
        }

        private bool _actif;

        public bool actif
        {

            get { return _actif; }

            set { _actif = value; }
        }

        public Users()
        {

        }

        public Users(string id_user, string login, string mdp, bool admin, string id_ps)
        {
            this.id_user = id_user;
            this.login = login;
            this.mdp = mdp;
            this.admin = admin;
            this.id_ps = id_ps;

        }
    }
}