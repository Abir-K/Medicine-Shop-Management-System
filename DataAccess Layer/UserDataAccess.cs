using Medicalshop.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicalshop.DataAccess_Layer
{
    class UserDataAccess
    {
        DataAccess dataAccess;
        public UserDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public bool UserLogin(string userName, string userPassword)
        {
            string sql = "SELECT UserDesignation, Password FROM UsersRegistration WHERE UserDesignation='" + userName + "' AND Password='" + userPassword + "';";
            SqlDataReader reader = dataAccess.GetData(sql);
             while(reader.Read())
            {
                Users user = new Users();
                user.UserPassword = reader["Password"].ToString();
                if(user.UserPassword==userPassword)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public int UpdateAdminPassword(string userPasswod)
        {
            string sql = "UPDATE UsersRegistration SET Password='" + userPasswod+ "'WHERE UserDesignation = 'Admin';";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public List<Users> GetAllData()
        {
            string sql = "SELECT * FROM UsersRegistration ;";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Users> users = new List<Users>();
            while (reader.Read())
            {
                Users user = new Users();
                user.UserId =(int) reader["UserId"];
                user.UserName = reader["UserName"].ToString();
                user.UserConatct = reader["UserContact"].ToString();
                user.UserAddress= reader["UserAddress"].ToString();
                user.UserDesignation = reader["UserDesignation"].ToString();
                user.UserDOB = reader["DateOfBirth"].ToString();
                users.Add(user);
            }

            return users;
        }

        public int UserAdd(Users user)
        {
            string sql = "INSERT INTO UsersRegistration(UserName,UserContact,UserAddress,UserDesignation,DateOfBirth) VALUES('" + user.UserName + "','" + user.UserConatct + "','" + user.UserAddress + "','" + user.UserDesignation + "','" + user.UserDOB + "');";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateUserInfo(Users user, int userId)
        {
            string sql = "UPDATE UsersRegistration SET UserName='" + user.UserName + "',UserContact='" + user.UserConatct + "',UserAddress='" + user.UserAddress + "',UserDesignation='" + user.UserDesignation + "',DateOfBirth='" + user.UserDOB + "' WHERE UserId='" + userId + "';";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int DeleteUser(int userId)
        {
            string sql = "DELETE FROM UsersRegistration WHERE UserId='" + userId + "';";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateUserPassword(string userNewPassword,string userName)
        {
            string sql = "UPDATE UsersRegistration SET Password='" + userNewPassword + "'WHERE UserDesignation = '"+userName+"';";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
    }
}
