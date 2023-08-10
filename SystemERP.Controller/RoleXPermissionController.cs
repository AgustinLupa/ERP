using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Data;

namespace SystemERP.Controller
{
    public class RoleXPermissionController
    {
        private RoleXPermissionData data = new RoleXPermissionData();

        public bool CreateRoleXPermi(int id_role, int id_permis, int add, int remove, int edit)
        {
            if(id_role <=0 || id_role == null)
            {
                return false;
            }

            if(id_permis <=0  || id_permis == null)
            {
                return false;
            }

            if(add <=0 || add==null) {
                return false;
            }

            if (remove <= 0 || remove ==null)
            {
                return false;
            }

            if (edit <=0 || remove==null)
            {
                return false;
            }

            return data.CreateRoleXPermi(new Model.RoleXPermissions() { Id_Role = id_role, Id_Permission = id_permis, Add=add, Remove=remove, Edit=edit});
        }
    }
}
