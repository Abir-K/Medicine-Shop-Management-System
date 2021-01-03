using Medicalshop.DataAccess_Layer;
using Medicalshop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicalshop.BusinessLogic_Layer
{
    class UserLoginServices
    {
        UserDataAccess userDataAccess;
        public UserLoginServices()
        {
            userDataAccess = new UserDataAccess();
        }

        public bool UsersLogin(string userName, string userPassword)
        {
            return userDataAccess.UserLogin(userName, userPassword);   
        }

        public int UpdateAdminPassword(string password)
        {
            return userDataAccess.UpdateAdminPassword(password);

        }
        public int UpdateUsersPassword(string password,string userName)
        {
            return userDataAccess.UpdateUserPassword(password,userName);

        }

    }
}
