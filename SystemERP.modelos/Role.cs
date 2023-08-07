using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemERP.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int State { get; set; }
        public List<RoleXPermissions> RolePermissions { get; set; }        
    }
}
