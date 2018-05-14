using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MEDESYS.BUSINESS_OBJECTS;

namespace MEDESYS.ADO
{
    public class Demandes_recuesADO : MySQL
    {

        public List<Demandes_recues> selectAll()
        {

            List<Demandes_recues> lst_demandesrecues = new List<Demandes_recues>();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM demandes_recues ORDER BY id_message";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Demandes_recues demande_recue = new Demandes_recues();

                demande_recue.id_message = Convert.ToString(reader["id_message"]);
                demande_recue.texte_message = Convert.ToString(reader["texte_message"]);
                demande_recue.date_message = Convert.ToDateTime(reader["date_message"]);
                demande_recue.xml = Convert.ToString(reader["xml"]);
                demande_recue.id_ps_exp = Convert.ToString(reader["id_ps_exp"]);
                demande_recue.id_ps_dest = Convert.ToString(reader["id_ps_dest"]);
                demande_recue.id_demande_recue = Convert.ToString(reader["id_demande_recue"]);


                lst_demandesrecues.Add(demande_recue);

            }

            connection.Close();

            return lst_demandesrecues;

        }

        public Demandes_recues selectDonneesFromIdDemandeRecue(string p_id_demande_recue)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM demandes_recues WHERE id_message='" + p_id_demande_recue + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            
            Demandes_recues demande_recue = null;

            if(reader.Read())
            {
                demande_recue = new Demandes_recues();

                demande_recue.id_message = Convert.ToString(reader["id_message"]);
                demande_recue.texte_message = Convert.ToString(reader["texte_message"]);
                demande_recue.date_message = Convert.ToDateTime(reader["date_message"]);
                demande_recue.xml = Convert.ToString(reader["xml"]);
                demande_recue.id_ps_exp = Convert.ToString(reader["id_ps_exp"]);
                demande_recue.id_ps_dest = Convert.ToString(reader["id_ps_dest"]);
                demande_recue.id_demande_recue = Convert.ToString(reader["id_demande_recue"]);
            }

            connection.Close();

            return demande_recue;
        }

        public string insertDemandeRecue(Demandes_recues p_demande_recue)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText =
                "INSERT INTO demandes_recues(id_message,texte_message,date_message,xml,id_ps_exp,id_ps_dest,id_demande_recue) VALUES('" +
                p_demande_recue.id_message + "','" + p_demande_recue.texte_message + "','" + p_demande_recue.date_message + "','" + p_demande_recue.xml + "','" +
                p_demande_recue.id_ps_exp + "','" + p_demande_recue.id_ps_dest + "','" + p_demande_recue.id_demande_recue + "')";

            MySqlDataReader reader = cmd.ExecuteReader();
            int rows = cmd.ExecuteNonQuery();

            connection.Close();

            return (rows + " ligne(s) insérée(s)");

        }

        public string updateDemandeRecue(Demandes_recues p_demande_recue)
        {
            return null;
        }

        public string deleteDemandeRecue(Demandes_recues p_demande_recue)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "DELETE FROM demandes_recues WHERE id_message='" + p_demande_recue.id_message+"'";

            MySqlDataReader reader = cmd.ExecuteReader();
            int rows = cmd.ExecuteNonQuery();

            connection.Close();

            return (rows + " ligne(s) supprimée(s)");
        }

    }
}
