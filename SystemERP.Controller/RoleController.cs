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

        public bool DeleteRole(Role role)
        {
            return data.DeleteRole(role);
        }

        public IEnumerable<Role> GetActiveRole()
        {
            return data.GetActiveRole();
        }

        public bool ReRegisterRole(Role role)
        {
            return data.ReRegister(role);
        }

        public Role GetByID(int id)
        {
            if(id <= 0)
            {
                return null;
            }
            return data.GetById(id);
        }

    }
}
