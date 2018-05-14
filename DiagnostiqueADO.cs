using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDESYS.BUSINESS_OBJECTS;
using MySql.Data.MySqlClient;
using MEDESYS.ADO;


namespace MEDESYS.ADO
{
    public class DiagnostiqueADO : MySQL
    {
        public List<Diagnostique> selectAll()
        {
            List<Diagnostique> lst_diagnostiques = new List<Diagnostique>();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM diagnostique";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Diagnostique diagnostique = new Diagnostique();

                diagnostique.id_diagnostique = Convert.ToString(reader ["id_diagnostique"]);
                diagnostique.date_diagnostique = Convert.ToDateTime(reader["date_diagnostique"]);
                diagnostique.diagnostique = Convert.ToString(reader["diagnostique"]);
                diagnostique.id_ps = Convert.ToString(reader["id_ps"]);
                diagnostique.id_patient = Convert.ToString(reader["id_patient"]);

                lst_diagnostiques.Add(diagnostique);

            }

            connection.Close();
            return lst_diagnostiques;
        }

        public List<Diagnostique> selectDiagnostiquesFromIdPatient(string p_id_patient)
        {

            List<Diagnostique> lst_diagnostiques = new List<Diagnostique>();
            MySqlCommand cmd = connection.CreateCommand(); ;

            cmd.CommandText = "SELECT * FROM diagnostique WHERE id_patient='" + p_id_patient + "'";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Diagnostique diagnostique = new Diagnostique();

                diagnostique.id_diagnostique = Convert.ToString(reader["id_diagnostique"]);
                diagnostique.date_diagnostique = Convert.ToDateTime(reader["date_diagnostique"]);
                diagnostique.diagnostique = Convert.ToString(reader["diagnostique"]);
                diagnostique.id_ps = Convert.ToString(reader["id_ps"]);
                diagnostique.id_patient = Convert.ToString(reader["id_patient"]);

                lst_diagnostiques.Add(diagnostique);

                }

            connection.Close();
            return lst_diagnostiques;
        }

        public void insertDiagnostique(Diagnostique p_diagnostique, string p_id_diagnostique)
        {

            List<Diagnostique> lst_diagnostiques = new List<Diagnostique>();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "INSERT INTO diagnostique(id_diagnostique, date_diagnostique, diagnostique, id_ps, id_patient) VALUES('" +
                p_id_diagnostique + "','" + p_diagnostique.date_diagnostique + "','" + p_diagnostique.diagnostique + "','" + p_diagnostique.id_ps + "','" +
                p_diagnostique.id_patient + "')";

            MySqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
        }

        public void updateDiagnostique(Diagnostique p_diagnostique)
        {

            List<Diagnostique> lst_diagnostiques = new List<Diagnostique>();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "UPDATE diagnostique SET id_diagnostique=" + p_diagnostique.id_diagnostique
                                                        + ", date_time=" + p_diagnostique.date_diagnostique
                                                        + ", diagnostique=" + p_diagnostique.diagnostique
                                                        + ", id_ps=" + p_diagnostique.id_ps
                                                        + ", id_patient" + p_diagnostique.id_patient;

            MySqlDataReader reader = cmd.ExecuteReader();
            connection.Close();

        }

        public void deleteDiagnostique(Diagnostique p_diagnostique)
        {
            List<Diagnostique> lst_diagnostiques = new List<Diagnostique>();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "DELETE FROM diagnostique WHERE id_diagnostique='" + p_diagnostique.id_diagnostique + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
        }
    }
}

