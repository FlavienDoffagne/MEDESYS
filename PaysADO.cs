using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDESYS.BUSINESS_OBJECTS;
using MySql.Data.MySqlClient;

namespace MEDESYS.ADO
{
    public class PaysADO : MySQL
    {

        public List<Pays> selectAll()
        {
            List<Pays> lst_pays = new List<Pays>();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM pays ORDER BY nom";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Pays pays = new Pays();

                pays.id_pays = Convert.ToString(reader["id_pays"]);
                pays.nom = Convert.ToString(reader["nom"]);

                lst_pays.Add(pays);
            }

            connection.Close();

            return lst_pays;
        }

        public Pays selectDonneesFromIdPays(String p_id_pays)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM pays WHERE id_pays='" + p_id_pays + "'";

            MySqlDataReader reader = cmd.ExecuteReader();


            Pays pays = null;

            if (reader.Read())
            {
                new Pays();

                pays.id_pays = Convert.ToString(reader["id_pays"]);
                pays.nom = Convert.ToString(reader["nom"]);
            }

            connection.Close();

            return pays;
        }

        public string insertPays(string p_id_pays, string p_nom)
        {

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "INSERT INTO pays (id_pays,nom) VALUES('" +
                p_id_pays + "','" + p_nom + "')";

            MySqlDataReader reader_pays = cmd.ExecuteReader();
            int rows = cmd.ExecuteNonQuery();

            connection.Close();

            return (rows + " lignes insérées");
        }
    }
}
