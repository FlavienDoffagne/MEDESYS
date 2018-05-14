using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MEDESYS.BUSINESS_OBJECTS;

namespace MEDESYS.ADO
{
    public class Demandes_envoyeesADO : MySQL
    {

        public List<Demandes_envoyees> selectAll()
        {
            List<Demandes_envoyees> lst_demandesenvoyees = new List<Demandes_envoyees>();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM demandes_envoyees ORDER BY id_message";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Demandes_envoyees demande_envoyee = new Demandes_envoyees();

                demande_envoyee.id_message = Convert.ToString(reader["id_message"]);
                demande_envoyee.texte_message = Convert.ToString(reader["texte_message"]);
                demande_envoyee.date_message = Convert.ToDateTime(reader["date_message"]);
                demande_envoyee.xml = Convert.ToString(reader["xml"]);
                demande_envoyee.id_ps_exp = Convert.ToString(reader["id_ps_exp"]);
                demande_envoyee.id_ps_dest = Convert.ToString(reader["id_ps_dest"]);
                demande_envoyee.id_demande = Convert.ToString(reader["id_demande"]);
                
                lst_demandesenvoyees.Add(demande_envoyee);

            }

            connection.Close();

            return lst_demandesenvoyees;

        }

        public Demandes_envoyees selectDonneesFromIdDemandeEnvoyee(string p_id_demande_envoyee)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM demandes_envoyees WHERE id_message='" + p_id_demande_envoyee + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            
            Demandes_envoyees demande_envoyee = null;

            if (reader.Read())
            {
                demande_envoyee = new Demandes_envoyees();

                demande_envoyee.id_message = Convert.ToString(reader["id_message"]);
                demande_envoyee.texte_message = Convert.ToString(reader["texte_message"]);
                demande_envoyee.date_message = Convert.ToDateTime(reader["date_message"]);
                demande_envoyee.xml = Convert.ToString(reader["xml"]);
                demande_envoyee.id_ps_exp = Convert.ToString(reader["id_ps_exp"]);
                demande_envoyee.id_ps_dest = Convert.ToString(reader["id_ps_dest"]);
                demande_envoyee.id_demande = Convert.ToString(reader["id_demande"]);
            }

            connection.Close();
            return demande_envoyee;
        }

        public string insertDemandeEnvoyee(Demandes_envoyees p_demande_envoyee)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText =
                "INSERT INTO demandes_envoyees(id_message,texte_message,date_message,xml,id_ps_exp,id_ps_dest,id_demande) VALUES('" +
                p_demande_envoyee.id_message + "','" + p_demande_envoyee.texte_message + "','" + p_demande_envoyee.date_message + "','" + p_demande_envoyee.xml + "','" +
                p_demande_envoyee.id_ps_exp + "','" + p_demande_envoyee.id_ps_dest + "','" + p_demande_envoyee.id_demande + "')";

            MySqlDataReader reader = cmd.ExecuteReader();
            int rows = cmd.ExecuteNonQuery();

            connection.Close();

            return (rows + " ligne(s) insérée(s)");

        }

        public string updateDemandeEnvoyee(Demandes_envoyees p_demande_envoyee)
        {
            return null;
        }

        public string deleteDemandeEnvoyee(Demandes_envoyees p_demande_envoyee)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText ="DELETE FROM demandes_envoyees WHERE id_message='"+p_demande_envoyee.id_message+"'";

            MySqlDataReader reader = cmd.ExecuteReader();
            int rows = cmd.ExecuteNonQuery();

            connection.Close();

            return (rows + " ligne(s) supprimée(s)");
        }
    }
}


