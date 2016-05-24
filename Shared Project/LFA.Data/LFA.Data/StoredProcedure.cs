using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Data
{
    public class StoredProcedure
    {
       
        public string strconn = "Data Source=.;uid=sa;password=system;initial catalog=LFABlog;";
        public void InsertRole()
        {
            Console.Write("Enter RoleName: ");
            string strRoleName = Console.ReadLine();
            Console.Write("Enter RoleDesc: ");
            string strRoleDesc = Console.ReadLine();
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "InsertRoles";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoleName", strRoleName);
                    cmd.Parameters.AddWithValue("@RoleDesc", strRoleDesc);


                    conn.Open();
                    var output = cmd.ExecuteNonQuery();
                    Console.WriteLine(output);
                }
            }
        }
        
    }
}
