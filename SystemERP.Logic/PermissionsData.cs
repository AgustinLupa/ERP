using Dapper;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Model;

namespace SystemERP.Data
{
    public class PermissionsData
    {
        public bool CreatePermission(Permissions permissions)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"INSERT INTO permissions(description) Values (@Description)";
                    var result = connection.Execute(mysql, permissions);
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

        public bool DeletePermission(Permissions permissions)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"UPDATE permissions SET state = 0 WHERE id =@Id";
                    var result = connection.Execute(mysql, permissions);
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

        public bool UpdatePermission(Permissions permissions)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"UPDATE permissions SET state = @State, description = @Description WHERE id =@Id";
                    var result = connection.Execute(mysql, permissions);
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

        public bool ReRegister(Permissions permissions)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"UPDATE permissions SET state=1 where (id = @Id)";
                    var result = connection.Execute(mysql, permissions);
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

        public Permissions GetByID(int Id)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"SELECT * FROM permissions where (id = @Id)";
                    Permissions result = connection.QuerySingleOrDefault<Permissions>(mysql, new { Id });                   
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
    }
}
