using LFA.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Biz.Ado
{
    public class RoleRepository
    {
        DataAccess db;
        public RoleRepository()
        {
            db = new DataAccess("Data Source=.;uid=sa;password=system;initial catalog=LFABlog;");
        }
        public List<Role> GetAll()
        {
            SqlDataReader dr = db.ExecDataReader("SELECT * FROM dbo.Roles");
            List<Role> lstRoles = new List<Role>();
            while (dr.Read())
            {
                Role objRole = new Role();
                objRole.RoleId = int.Parse(dr[0].ToString());
                objRole.RoleName = dr[1].ToString();
                objRole.RoleDesc = dr[2].ToString();
                lstRoles.Add(objRole);
            }
            return lstRoles;
        }
        public Role GetSingleRole(int roleID)
        {
            return GetAll().FirstOrDefault(x => x.RoleId == roleID);
        }
        public int Add(Role objRole)
        {
            return db.ExecNonQueryProc("dbo.InsertRoles", "@RoleName", objRole.RoleName, "@RoleDesc", objRole.RoleDesc);
        }
    }
}
