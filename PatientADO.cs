using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDESYS.BUSINESS_OBJECTS;
using MySql.Data.MySqlClient;

namespace MEDESYS.ADO
{
    public class PatientADO : MySQL
    {

        public List<Patient> selectAll()
        {
            List<Patient> lst_patient = new List<Patient>();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM patient ORDER BY nom";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Patient patient = new Patient();

                patient.id_patient = Convert.ToString(reader["id_patient"]);
                patient.nom = Convert.ToString(reader["nom"]);
                patient.prenom = Convert.ToString(reader["prenom"]);
                patient.id_nat = Convert.ToString(reader["id_nat"]);
                patient.date_naissance = Convert.ToDateTime(reader["date_naissance"]);
                patient.sexe = Convert.ToString(reader["sexe"]);
                patient.adresse = Convert.ToString(reader["adresse"]);
                patient.tel = Convert.ToString(reader["tel"]);
                patient.mob = Convert.ToString(reader["mob"]);
                patient.id_ps = Convert.ToString(reader["id_ps"]);
                patient.id_ville_residence = Convert.ToString(reader["id_ville_residence"]);
                patient.id_ville_naissance = Convert.ToString(reader["id_ville_naissance"]);

                lst_patient.Add(patient);

            }

            connection.Close();

            return lst_patient;

        }

        public Patient selectDonneesFromIdPatient(string p_id_patient)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM patient WHERE id_patient='" + p_id_patient + "'";

            MySqlDataReader reader = cmd.ExecuteReader();

            Patient patient = null;

            if (reader.Read())
            {
                new Patient();

                patient.id_patient = Convert.ToString(reader["id_patient"]);
                patient.nom = Convert.ToString(reader["nom"]);
                patient.prenom = Convert.ToString(reader["prenom"]);
                patient.id_nat = Convert.ToString(reader["id_nat"]);
                patient.date_naissance = Convert.ToDateTime(reader["date_naissance"]);
                patient.sexe = Convert.ToString(reader["sexe"]);
                patient.adresse = Convert.ToString(reader["adresse"]);
                patient.tel = Convert.ToString(reader["tel"]);
                patient.mob = Convert.ToString(reader["mob"]);
                patient.antecedents = Convert.ToString(reader["antecedents"]);
            }

            connection.Close();

            return patient;
        }

        public void insertPatient(Patient p_patient, string p_id_patient)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText =
                "INSERT INTO patient(id_patient,nom,prenom,id_nat,date_naissance,sexe,adresse,tel,mob,antecedents,id_ps,id_ville_residence,id_ville_naissance) VALUES('" +
                p_id_patient + "','" + p_patient.nom + "','" + p_patient.prenom + "','" + p_patient.id_nat + "','" +
                p_patient.date_naissance + "','" + p_patient.sexe + "','" + p_patient.adresse + "','" + p_patient.tel + "','" + p_patient.mob +
                "','" + p_patient.antecedents + "','tt'," + "'yy'," + "'vv" + "')";

            MySqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
        }

        public void deletePatient(Patient p_patient)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "DELETE FROM patient WHERE id_patient='" + p_patient.id_patient + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
        }

        public void updatePatient(Patient p_patient)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "UPDATE patient SET nom=" + p_patient.nom +
                              ",prenom=" + p_patient.prenom +
                              ",id_nat=" + p_patient.id_nat +
                              ",date_naissance=" + p_patient.date_naissance +
                              ",sexe=" + p_patient.sexe +
                              ",adresse=" + p_patient.adresse +
                              ",tel=" + p_patient.tel +
                              ",mob=" + p_patient.mob +
                              ",antecedents=" + p_patient.antecedents +
                              ",id_ville_naissance=" + p_patient.id_ville_naissance +
                              ",id_ville_residence=" + p_patient.id_ville_residence + " " +
                              "WHERE id_patient='" + p_patient.id_patient + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
        }
    }
}

