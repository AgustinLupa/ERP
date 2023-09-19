using Dapper;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Model;

namespace SystemERP.Data
{
    public class RoleData
    {
        public IEnumerable<Role> GetAll()
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var query = @"
                    SELECT r.id, r.name, r.state,
                    rp.id, rp.id_role, rp.id_permissions, rp.add, rp.remove, rp.edit,
                    p.id, p.description, p.state
                    FROM roles r
                    JOIN rolesxpermissions rp ON r.id = rp.id_role
                    JOIN permissions p ON rp.id_permissions = p.id";
                    var roleDictionary = new Dictionary<int, Role>();
                    connection.Query<Role, RoleXPermissions, Permissions, Role>(
                        query,
                        (role, rolePermissions, permissions) =>
                        {
                            if (!roleDictionary.TryGetValue(role.Id, out var roleEntry))
                            {
                                roleEntry = role;
                                roleEntry.RolePermissions = new List<RoleXPermissions>();
                                roleDictionary.Add(roleEntry.Id, roleEntry);
                            }
                            rolePermissions.Permission = permissions;
                            roleEntry.RolePermissions.Add(rolePermissions);
                            return roleEntry;
                        },
                        splitOn: "Id, Id, Id"
                    );
                    connection.Close();
                    return roleDictionary.Values;
                }
                catch (Exception)
                {
                    connection.Close();
                    List<Role> roles = new List<Role>();
                    return roles;
                }
            }                              
        }

        public int AddRole(Role role)
        {            
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var insertQuery = @"
                        INSERT INTO roles (name)
                        VALUES (@Name);
                        SELECT CAST(SCOPE_IDENTITY() as int);";

                    int roleId = connection.QueryFirstOrDefault<int>(insertQuery, role);
                    connection.Close();
                    return roleId;
                }
                catch (Exception)
                {
                    connection.Close();
                    return 0;
                }
                 
            }            
        }

        public bool DeleteRole(Role role)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"UPDATE roles SET state=0 where (name = @Name)";
                    var result = connection.Execute(mysql, role);
                    connection.Close();
                    return true;
                }
                catch (Exception)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        public IEnumerable<Role> GetActiveRole()
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var query = @"
                    SELECT r.id, r.name, r.state,
                    rp.id, rp.id_role, rp.id_permissions, rp.add, rp.remove, rp.edit,
                    p.id, p.description, p.state
                    FROM roles r
                    JOIN rolesxpermissions rp ON r.id = rp.id_role
                    JOIN permissions p ON rp.id_permissions = p.id
                    WHERE ((r.state = 1) AND (p.state = 1))";
                    var roleDictionary = new Dictionary<int, Role>();
                    connection.Query<Role, RoleXPermissions, Permissions, Role>(
                        query,
                        (role, rolePermissions, permissions) =>
                        {
                            if (!roleDictionary.TryGetValue(role.Id, out var roleEntry))
                            {
                                roleEntry = role;
                                roleEntry.RolePermissions = new List<RoleXPermissions>();
                                roleDictionary.Add(roleEntry.Id, roleEntry);
                            }

                            rolePermissions.Permission = permissions;
                            roleEntry.RolePermissions.Add(rolePermissions);
                            return roleEntry;
                        },
                        splitOn: "Id, Id, Id"
                    );
                    connection.Close();
                    return roleDictionary.Values;
                }
                catch (Exception)
                {
                    connection.Close();
                    List<Role> roles = new List<Role>();
                    return roles;
                }

            }            
        }

        public bool ReRegister(Role role)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"UPDATE roles SET state=1 where (id = @Id)";
                    var result = connection.Execute(mysql, role);
                    if (result > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    connection.Close();
                    return false;

                }
                catch (Exception)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        public Role GetById(int id)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var query = @"
                    SELECT r.id, r.name, r.state,
                    rp.id, rp.id_role, rp.id_permissions, rp.add, rp.remove, rp.edit,
                    p.id, p.description, p.state
                    FROM roles r
                    JOIN rolesxpermissions rp ON r.id = rp.id_role
                    JOIN permissions p ON rp.id_permissions = p.id
                    WHERE (r.id = @Id)";
                    var roleDictionary = new Dictionary<int, Role>();
                    connection.Query<Role, RoleXPermissions, Permissions, Role>(
                        query,
                        (role, rolePermissions, permissions) =>
                        {
                            if (!roleDictionary.TryGetValue(role.Id, out var roleEntry))
                            {
                                roleEntry = role;
                                roleEntry.RolePermissions = new List<RoleXPermissions>();
                                roleDictionary.Add(roleEntry.Id, roleEntry);
                            }

                            rolePermissions.Permission = permissions;
                            roleEntry.RolePermissions.Add(rolePermissions);
                            return roleEntry;
                        },
                        new { Id = id },
                        splitOn: "Id, Id, Id"
                    );
                    connection.Close();
                    return roleDictionary.Values.FirstOrDefault();
                }
                catch (Exception)
                {
                    connection.Close();
                    Role role = new Role();
                    return role;
                }
            }
        }

        public bool UpdateRole(Role role)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = "UPDATE roles SET name=@Name,state=@State WHERE id = @Id";
                    var result = connection.Execute(mysql, role);
                    if (result > 0)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                } finally { connection.Close(); }
            }
        }
    }
}
