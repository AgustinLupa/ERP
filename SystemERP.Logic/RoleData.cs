using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Interface;
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
                    var mysql = @"SELECT * FROM roles";
                    var result = connection.Query<Role>(mysql).ToList();
                    connection.Close();
                    return result;
                }
                catch (Exception)
                {
                    connection.Close();
                    return null;
                }
            }
        }

        public bool AddRole(Role role)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"INSERT INTO roles(name) VALUES (@Name)";
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
                    var mysql = @"SELECT * FROM roles where (state = 1)";
                    var result = connection.Query<Role>(mysql).ToList();
                    connection.Close();
                    return result;
                }
                catch (Exception)
                {
                    connection.Close();
                    return null;
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
                    var mysql = @"UPDATE roles SET state=1 where (name = @Name)";
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
    }
}
