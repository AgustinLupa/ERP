using Dapper;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Model;

namespace SystemERP.Data
{
    public class RoleXPermissionData
    {
        public bool CreateRoleXPermi(RoleXPermissions roleXPermissions)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var insertQuery = @"
                        INSERT INTO rolesxpermissions (`id_role`, `id_permissions`, `add`, `remove`, `edit`)
                        VALUES (@Id_Role, @Id_Permission, @Add, @Remove, @Edit);"
                    ;

                    var result = connection.Execute(insertQuery, roleXPermissions);
                    connection.Close();
                    if (result > 0)
                    {                        
                        return true;
                    }                    
                    return false;                   
                }
                catch (Exception)
                {
                    connection.Close();
                    return false;
                }

            }
        }
    }
}
