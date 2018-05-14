using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDESYS.BUSINESS_OBJECTS;
using MySql.Data.MySqlClient;

namespace MEDESYS.ADO
{
    class UsersADO : MySQL
    {
        public List<Users> selectAll()
        {
            List<Users> lst_user = new List<Users>();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM users";

            MySqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                Users user = new Users();

                user.id_user = Convert.ToString(reader["id_user"]);
                user.login = Convert.ToString(reader["login"]);
                user.mdp = Convert.ToString(reader["mdp"]);
                user.admin = Convert.ToBoolean(reader["admin"]);
                user.id_ps = Convert.ToString(reader["id_ps"]);
                user.actif = Convert.ToBoolean(reader["actif"]);
                
                lst_user.Add(user);
            }

            connection.Close();
            return lst_user;
        }


        public Users selectDonneesFromIdUsers(string p_id_user)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM users WHERE id_user='" + p_id_user + "'";

            MySqlDataReader reader = cmd.ExecuteReader();

            Users user = null;
           
            while (reader.Read())
            {
                new Users();

                user.id_user = Convert.ToString(reader["id_user"]);
                user.login = Convert.ToString(reader["login"]);
                user.mdp = Convert.ToString(reader["mdp"]);
                user.admin = Convert.ToBoolean(reader["admin"]);
                user.id_ps = Convert.ToString(reader["id_ps"]);
                user.actif = Convert.ToBoolean(reader["actif"]);
            }

            connection.Close();
            return user;
        }


        public void insertUser(Users p_user, string p_id_user)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText =
                "INSERT INTO users(id_user,login,mdp,admin,actif,id_ps) VALUES('" +
                 p_id_user + "','" + p_user.login + "','" + p_user.mdp + "','" + p_user.admin + "','" +
                p_user.id_ps + "','" + p_user.actif + "')";

            MySqlDataReader reader = cmd.ExecuteReader();
            connection.Close();

        }

        // Permet d' updater le login, le mdp et les droits admin d'un user.
        public void updateUser(Users p_user)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "UPDATE users SET login = '"  + p_user.login +
                              "', mdp = '"  + p_user.mdp + 
                              "', admin = '" + p_user.admin + 
                              "', actif = '" + p_user.actif +  
                              "' WHERE id_user = '" + p_user.id_user + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
        }


        public void deleteUser(Users p_user)
        {

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "DELETE FROM users WHERE id_user = '" + p_user.id_user + "'";
            connection.Close();
        }
    }
}
