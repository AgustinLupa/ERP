using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Data;
using SystemERP.Model;

namespace SystemERP.Controller
{
    public class RoleXPermissionController
    {
        private RoleXPermissionData data = new RoleXPermissionData();
        List<RoleXPermissions> roleXPermissions = new List<RoleXPermissions>();
        public void CreateRoleXPermi(int id_role, int id_permis, int add, int remove, int edit)
        {              
            data.CreateRoleXPermi(new Model.RoleXPermissions() { Id_Role = id_role, Id_Permission = id_permis, Add=add, Remove=remove, Edit=edit});
        }

        public bool AddPermissionToList(int id, bool add, bool delete, bool update)
        {
            if(id <= 0)
            {
                return false;
            }
            if (ContainIdAdmin())
                return false;
            if (!roleXPermissions.Any(item => item.Id_Permission == id))
            {                
                int ad = add ? 1 : 0;
                int del = delete ? 1 : 0;
                int upda = update ? 1 : 0;
                roleXPermissions.Add(new RoleXPermissions() { Id_Permission = id, Add = ad, Edit = upda, Remove = del });               
                return true;
            }
            return false;
        }

        public void RemovePermissionToListById(int id)
        {
            roleXPermissions.RemoveAt(id);
        }

        public bool ContainIdAdmin()
        {
            if(roleXPermissions.Any(item => item.Id_Permission == 1))
            {
                roleXPermissions = roleXPermissions.Where(item => item.Id_Permission == 1).ToList();
                return true;
            }
            return false;
        }

        public void CreateForList()
        {
            foreach (var item in roleXPermissions)
            {
                CreateRoleXPermi(item.Id_Role, item.Id_Permission, item.Add, item.Remove, item.Edit);
            }
        }

        public void SetRoleInList(int id)
        {
            foreach(var item in roleXPermissions)
            {
                item.Id_Role = id;
            }
        }

        public void ClearList()
        {
            this.roleXPermissions.Clear();
        }
    }
}
