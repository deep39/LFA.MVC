using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Data
{
    public class SelectData
    {
         SqlConnection conn = new SqlConnection("Data Source=.;uid=sa;password=system;initial catalog=LFABlog;");
        public void GetUser()
        {            
            SqlCommand cmdu = new SqlCommand();
            cmdu.Connection = conn;
            cmdu.CommandText = "SELECT * FROM dbo.Users";
            cmdu.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader du = cmdu.ExecuteReader();            
            List<User> lstUsers = new List<User>();            

            while (du.Read())
            {
                User objUsers = new User();
                objUsers.UserId = int.Parse(du[0].ToString());
                objUsers.UserName = du["UserName"].ToString();
                objUsers.Password = du[2].ToString();
                objUsers.Email = du[3].ToString();
                objUsers.CreatedDate = DateTime.Parse(du[4].ToString());
                objUsers.RoleId = int.Parse(du[5].ToString());
                lstUsers.Add(objUsers);
            }
            du.Close();
            conn.Close();

            Console.WriteLine("the Users are:");
            foreach (var objUsers in lstUsers)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", objUsers.UserName, objUsers.Password, objUsers.Email, objUsers.CreatedDate);
            }
        }

        public void GetRoles()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM dbo.Roles";
            cmd.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Role> lstRoles = new List<Role>();

            while(dr.Read())
            {
                Role objRole = new Role();
                objRole.RoleId = int.Parse(dr[0].ToString());
                objRole.RoleName = dr["RoleName"].ToString();
                objRole.RoleDesc = dr[2].ToString();
                //Console.WriteLine(dr[1]);
                lstRoles.Add(objRole);
            }
            dr.Close();
            conn.Close();
            
            Console.WriteLine("the Roles are:");
            foreach (var item in lstRoles)
            {
                Console.WriteLine("{0} - {1}",item.RoleName,item.RoleDesc);
            }
        }
        public void GetPost()
        {
            SqlCommand cmdp = new SqlCommand();
            cmdp.Connection = conn;
            cmdp.CommandText = "SELECT * FROM dbo.Posts";
            cmdp.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader dp = cmdp.ExecuteReader();
            List<Post> lstPosts = new List<Post>();

            while (dp.Read())
            {
                Post objPosts = new Post();
                objPosts.PostId = int.Parse(dp[0].ToString());
                objPosts.PostTitle = dp[1].ToString();
                objPosts.PostCotent = dp[2].ToString();
                objPosts.CreatedDate = DateTime.Parse(dp[3].ToString());
                objPosts.UserId = int.Parse(dp[4].ToString());
                lstPosts.Add(objPosts);
            }
            dp.Close();
            conn.Close();

            Console.WriteLine("the Posts are:");
            foreach (var objUsers in lstPosts)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4}", objUsers.PostId, objUsers.PostTitle, objUsers.PostCotent, objUsers.CreatedDate, objUsers.UserId);
            }
        }

    }
}
