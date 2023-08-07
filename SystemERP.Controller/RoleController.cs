using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Data;
using SystemERP.Model;

namespace SystemERP.Controller
{
    public class RoleController
    {
        private readonly RoleData data = new RoleData();
        public IEnumerable<Role> GetAll()
        {
            return data.GetAll();      
        }

        public Role GetById(int id)
        {            
            return data.GetById(id);
        }

        public int CreateRole(string name)
        {
            if(name == null || name == "") {
                return 0;
            }
            Role role = new Role() { 
                Name = name,
            };
            return data.AddRole(role);                        
        }


    }
}
