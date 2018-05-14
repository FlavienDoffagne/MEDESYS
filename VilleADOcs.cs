using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDESYS.BUSINESS_OBJECTS;
using MySql.Data.MySqlClient;

namespace MEDESYS.ADO
{
    public class VilleADO : MySQL
    {
        public List<Ville> selectAll()
        {
            List<Ville> lst_villes = new List<Ville>();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM ville";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Ville ville = new Ville();

                ville.id_ville = Convert.ToString(reader["id_ville"]);
                ville.nom = Convert.ToString(reader["nom"]);
                ville.cp = Convert.ToString(reader["cp"]);
                ville.id_pays = Convert.ToString(reader["id_pays"]);

                lst_villes.Add(ville);

            }
            
            connection.Close();
            return lst_villes;

        }

        public Ville selectVilleFromIdPatient(string p_id_patient)
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM ville WHERE id_patient='" + p_id_patient + "'";

            MySqlDataReader reader = cmd.ExecuteReader();

            Ville ville = null;

            if (reader.Read())
            {
                new Ville();

                ville.id_ville = Convert.ToString(reader["id_ville"]);
                ville.nom = Convert.ToString(reader["nom"]);
                ville.cp = Convert.ToString(reader["cp"]);
                ville.id_pays = Convert.ToString(reader["id_pays"]);

            }

            return ville;
        }
    }
}
