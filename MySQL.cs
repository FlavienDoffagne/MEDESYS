using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDESYS.BUSINESS_OBJECTS;
using MySql.Data.MySqlClient;

namespace MEDESYS.ADO
{
    public class MySQL
    {
        private static MySqlConnection _connection;

        public static MySqlConnection connection
        {
            get
            {
                if (_connection == null)
                {
                    string connectionString = "SERVER=localhost; DATABASE=MEDESYSDB; UID=root; PASSWORD=;persistsecurityinfo=True;port=3306;SslMode=none";
                    _connection = new MySqlConnection(connectionString);
                }

                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                return _connection;
            }
        }


    }
}
