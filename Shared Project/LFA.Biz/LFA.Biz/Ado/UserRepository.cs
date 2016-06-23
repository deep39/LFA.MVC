using LFA.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Biz
{
    /// <summary>
    /// User Repository to get all data related to users
    /// </summary>
    public class UserRepository
    {
        //private static List<User> _listUsers;
        DataAccess db;

        public UserRepository()
        {
            //_listUsers = new List<User>();
            //User u1 = new User { UserId = 1, UserName = "user1", Password = "password" };
            //User u2 = new User { UserId = 2, UserName = "user2", Password = "password" };
            //List<User> listUsers = new List<User>();
            //listUsers.Add(u1);
            //listUsers.Add(u2);
            //for (int i = 3; i < 10; i++)
            //{
            //    User u = new User { UserId = i, UserName = "user" + i, Password = "password" };
            //    listUsers.Add(u);
            //}
            //_listUsers = listUsers;
            db = new DataAccess("Data Source=.;uid=sa;password=system;initial catalog=LFABlog;");
        }
        public List<User> GetAll()
        {
            //User u1 = new User { UserID = 1, UserName = "user1", Password = "password" };
            //User u2 = new User { UserID = 2, UserName = "user2", Password = "password" };
            //List<User> listUsers = new List<User>();
            //listUsers.Add(u1);
            //listUsers.Add(u2);
            //for (int i = 3; i < 10; i++)
            //{
            //    User u = new User { UserID = i, UserName = "user" + i, Password = "password" };
            //    listUsers.Add(u);
            //}
            //_listUsers = listUsers;
            SqlDataReader dr = db.ExecDataReader("SELECT * FROM dbo.Users");
            List<User> lstUsers = new List<User>();
            while (dr.Read())
            {
                User objUser = new User();
                objUser.UserId = int.Parse(dr[0].ToString());
                objUser.UserName = dr[1].ToString();
                objUser.Password = dr[2].ToString();
                objUser.Email = dr[3].ToString();
                objUser.CreatedDate = DateTime.Parse(dr[4].ToString());
                objUser.RoleId = int.Parse(dr[5].ToString());
                lstUsers.Add(objUser);
            }
            dr.Close();
            return lstUsers;
        }

        public int Add(User objUser)
        {
            objUser.UpdateDate = DateTime.Now;
            objUser.UpdateUserID = 1;

            return db.ExecNonQueryProc("dbo.InsertUsers", "@UserName", objUser.UserName, "@Password", objUser.Password, "@Email", objUser.Email, "@RoleId", objUser.RoleId);
        }

        public int Edit(User objUser)
        {
            return db.ExecNonQueryProc("dbo.UpdateUser", "@UserId", objUser.UserId, "@UserName", objUser.UserName, "@Password", objUser.Password, "@Email", objUser.Email, "@RoleId", objUser.RoleId);
        }

        public int Delete(int UserId)
        {
            return db.ExecNonQueryProc("dbo.DeleteUser", "@UserId", UserId);
        }
    }
}
