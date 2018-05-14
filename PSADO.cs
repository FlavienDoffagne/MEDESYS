using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDESYS.BUSINESS_OBJECTS;
using MySql.Data.MySqlClient;

namespace MEDESYS.ADO
{
    public class PSADO : MySQL
    {
        public List<ProfessionnelSante> selectAll()
        {
            List<ProfessionnelSante> lst_ps = new List<ProfessionnelSante>();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT id_ps,nom,prenom FROM professionnel_sante ORDER BY nom";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ProfessionnelSante ps = new ProfessionnelSante();

                ps.id_ps = Convert.ToString(reader["id_ps"]);
                ps.nom = Convert.ToString(reader["nom"]);
                ps.prenom = Convert.ToString(reader["prenom"]);

                lst_ps.Add(ps);

            }

            connection.Close();

            return lst_ps;
        }

        public ProfessionnelSante selectDonneesFromIdPS(string p_id_ps)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM patient WHERE id_ps='" + p_id_ps + "'";

            MySqlDataReader reader = cmd.ExecuteReader();

            ProfessionnelSante ps = null;

            if ((reader.Read()))
            {
                ps = new ProfessionnelSante();


                ps.id_ps = Convert.ToString(reader["id_ps"]);
                ps.nom = Convert.ToString(reader["nom"]);
                ps.prenom = Convert.ToString(reader["prenom"]);
                ps.ins = Convert.ToString(reader["ins"]);
                //ps.categorie = Convert.ToString(reader["categorie"]);
                //ps.specialite = Convert.ToString(reader["specialite"]);
                ps.tel = Convert.ToString(reader["tel"]);
                ps.mob = Convert.ToString(reader["mob"]);
                ps.adresse = Convert.ToString(reader["adresse"]);
                ps.mail = Convert.ToString(reader["mail"]);
                ps.fax = Convert.ToString(reader["fax"]);
                ps.id_ville = Convert.ToString(reader["id_ville"]);

            }

            connection.Close();
            return ps;
        }

        public void insertPS(ProfessionnelSante p_ps, string p_id_ps)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText =
                "INSERT INTO professionnel_sante(id_ps,nom,prenom,ins,categorie,specialite,tel,mob,adresse,mail,fax,id_ville) VALUES('" +
                p_id_ps + "','" + p_ps.nom + "','" + p_ps.prenom + "','" + p_ps.ins + "','" +
                p_ps.categorie + "','" + p_ps.specialite + "','" + p_ps.tel + "','" + p_ps.mob + "','" + p_ps.adresse +
                "','" + p_ps.mail + "','" + p_ps.fax + "'," + "'yy'" + ")";

            MySqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
        }

        public void deletePS(ProfessionnelSante p_ps)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "DELETE FROM professionnel_sante WHERE id_ps='" + p_ps.id_ps + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
        }

        public void updatePS(ProfessionnelSante p_ps)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "UPDATE consultation SET nom=" + p_ps.nom +
                              ",prenom=" + p_ps.prenom +
                              ",ins=" + p_ps.ins +
                              ",categorie=" + p_ps.categorie +
                              ",specialite=" + p_ps.specialite +
                              ",tel=" + p_ps.tel +
                              ",mob=" + p_ps.mob +
                              ",adresse=" + p_ps.adresse +
                              ",mail=" + p_ps.mail +
                              ",fax=" + p_ps.mail +
                              ",id_ville=" + p_ps.id_ville + " " +
                              "WHERE id_consult='" + p_ps.id_ps + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
        }

    }
}

