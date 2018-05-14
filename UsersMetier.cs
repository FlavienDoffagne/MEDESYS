using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDESYS.ADO;
using MEDESYS.BUSINESS_OBJECTS;
using MEDESYS.OUTILS;

namespace MEDESYS.METIER
{
    class UsersMetier
    {
        private UsersADO _usersado;

        public UsersADO usersado
        {

            get { return _usersado; }

            set { _usersado = value; }
        }

        public UsersMetier()
        {
            usersado = new UsersADO();
        }

        public List<Users> selectAllUsers()
        {
            return usersado.selectAll();
        }

        public Users selectDonneesFromIdUsers(string p_id_user)
        {
            return usersado.selectDonneesFromIdUsers(p_id_user);
        }

        public void insertUser(Users p_user)
        {
            string p_id_ps = OutilsUUID.generateUUID();

            usersado.insertUser(p_user, p_id_ps);
        }
        public void updateUsers(Users p_user)
        {
            usersado.updateUser(p_user);
        }
        public void deleteUser(Users p_user)
        {
            usersado.deleteUser(p_user);
        }
    }
}

