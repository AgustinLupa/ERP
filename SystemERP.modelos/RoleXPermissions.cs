using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemERP.Model
{
    public class RoleXPermissions
    {
        public int Id { get; set; }
        public int Id_Role { get; set; }
        public int Id_Permissions { get; set; }
        public int Add { get; set; }
        public int Delete { get; set; }
        public int Edit { get; set; }
    }
}
