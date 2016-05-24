using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Data
{
    public class Role : Base
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public String RoleDesc { get; set; }
    }
}
