using Medicalshop.DataAccess_Layer;
using Medicalshop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicalshop.BusinessLogic_Layer
{
    class UserInfoServices
    {
        UserDataAccess userDataAccess;
        public UserInfoServices()
        {
            userDataAccess = new UserDataAccess();
        }

        public List<Users> GetAllInfo()
        {
            return this.userDataAccess.GetAllData();
        }

        public int AddnewUser(string userName, string userContact, string userAddress, string userDesignation, string userDOB)
        {
            Users user = new Users();
            user.UserName = userName;
            user.UserConatct = userContact;
            user.UserAddress = userAddress;
            user.UserDesignation = userDesignation;
            user.UserDOB = userDOB;
            return this.userDataAccess.UserAdd(user);
        }

        public int UpdateExistingUser(string userName, string userContact, string userAddress, string userDesignation, string userDOB,int userId)
        {
            Users user = new Users();
            user.UserName = userName;
            user.UserConatct = userContact;
            user.UserAddress = userAddress;
            user.UserDesignation = userDesignation;
            user.UserDOB = userDOB;
            return this.userDataAccess.UpdateUserInfo(user,userId);
        }

        public int DeleteExitingUser(int userId)
        {
            return this.userDataAccess.DeleteUser(userId);
        }
    }
}

