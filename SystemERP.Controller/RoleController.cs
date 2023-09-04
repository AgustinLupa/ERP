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
        private List<Role> roles = new List<Role>();
        private Role role;
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

        public IEnumerable<Role> GetActiveRoles()
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

        public void SetRoles()
        {
            roles = GetAll().ToList();
            roles.OrderByDescending(item => item.Name);
        }

        public List<Role> GetRoles()
        {
            return roles;
        }
        
        public Role SelectRole(int id)
        {
            return roles[id];
        }

        public void SetRoleActive(Role role)
        {
            this.role = role;
        }

        public Role GetRoleActive()
        {
            return role;
        }

        public bool UpdateRole(int id,string name, int state)
        {
            if(string.IsNullOrEmpty(name))
            {
                return false;
            }
            Role role = new Role() {
                Id = id,
                Name = name,
                State = state
            };
            return data.UpdateRole(role);
        }
    }
}
