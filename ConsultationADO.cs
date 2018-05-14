using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDESYS.BUSINESS_OBJECTS;
using MySql.Data.MySqlClient;

namespace MEDESYS.ADO
{
    public class ConsultationADO : MySQL
    {
        public List<Consultation> selectAll()
        {
            List<Consultation> lst_consultations = new List<Consultation>();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM consultation";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Consultation consultation = new Consultation();

                consultation.id_consult = Convert.ToString(reader["id_consult"]);
                consultation.date_consultation = Convert.ToDateTime(reader["date_consultation"]);
                consultation.ecg = Convert.ToString(reader["ecg"]);
                consultation.phono = Convert.ToString(reader["phono"]);
                consultation.foyer = Convert.ToString(reader["foyer"]);
                consultation.poids = Convert.ToDouble(reader["poids"]);
                consultation.pression = Convert.ToDouble(reader["pression"]);
                consultation.pression_arterielle_systolique = Convert.ToDouble(reader["pression_arterielle_systolique"]);
                consultation.pression_arterielle_diastolique = Convert.ToDouble(reader["pression_arterielle_diastolique"]);
                consultation.obeservation = Convert.ToString(reader["obeservation"]);

                lst_consultations.Add(consultation);

            }

            connection.Close();

            return lst_consultations;

        }

        public List<Consultation> selectConsultationsFromIdPatient(string p_id_patient)
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM consultation WHERE id_patient='" + p_id_patient + "'";

            MySqlDataReader reader = cmd.ExecuteReader();

            List<Consultation> lst_consultations = new List<Consultation>();

            Consultation consultation = null;
            
            if (reader.Read())
            {
                new Consultation();

                consultation.id_consult = Convert.ToString(reader["id_consult"]);
                consultation.date_consultation = Convert.ToDateTime(reader["date_consultation"]);
                consultation.ecg = Convert.ToString(reader["ecg"]);
                consultation.phono = Convert.ToString(reader["phono"]);
                consultation.foyer = Convert.ToString(reader["foyer"]);
                consultation.poids = Convert.ToDouble(reader["poids"]);
                consultation.pression = Convert.ToDouble(reader["pression"]);
                consultation.pression_arterielle_systolique = Convert.ToDouble(reader["pression_arterielle_systolique"]);
                consultation.pression_arterielle_diastolique = Convert.ToDouble(reader["pression_arterielle_diastolique"]);
                consultation.obeservation = Convert.ToString(reader["obeservation"]);

                lst_consultations.Add(consultation);
            }

            connection.Close();

            return lst_consultations;
        }

        public void insertConsultation(Consultation p_consultation, string p_id_consult)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "INSERT INTO consultation(id_consult,date_consultation,foyer,phono,ecg,poids,pression,pression_arterielle_systolique,pression_arterielle_diastolique," +
                              "obeservation,id_ps,id_patient) VALUES('" + p_id_consult + "','" + p_consultation.date_consultation + "','" + p_consultation.foyer + "','" + p_consultation.phono + "','" +
                              p_consultation.ecg + "','" + p_consultation.poids + "','" + p_consultation.pression + "','" + p_consultation.pression_arterielle_systolique + "','" + p_consultation.pression_arterielle_diastolique + "','"
                              + p_consultation.obeservation + "','tt'," + "'yy'" + ")";

            MySqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
        }

        public void deleteConsultation(string p_id_consult)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "DELETE FROM consultation WHERE id_consult='" + p_id_consult + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
        }

        public void updateConsultation(Consultation p_consultation)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "UPDATE consultation SET date_consultation=" + p_consultation.date_consultation +
                              ",foyer=" + p_consultation.foyer +
                              ",phono=" + p_consultation.phono +
                              ",ecg=" + p_consultation.ecg +
                              ",poids=" + p_consultation.poids +
                              ",pression=" + p_consultation.pression +
                              ",pression_arterielle_systolique=" + p_consultation.pression_arterielle_systolique +
                              ",pression_arterielle_diastolique=" + p_consultation.pression_arterielle_diastolique +
                              ",obeservation=" + p_consultation.obeservation + " " +
                              "WHERE id_consult='" + p_consultation.id_consult + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
        }
    }
}
