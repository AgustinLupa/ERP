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
    public class UserData
    {
        public IUser Login(IUser user)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                IUser result=null;
                try
                {
                    connection.Open();
                    var mysql = @"SELECT * FROM users WHERE((state = 1) and ((name = @Name) and (password = @Password)))";                   
                    result = connection.Query<User>(mysql, user).FirstOrDefault();                   
                    connection.Close();
                    return result;               
                }
                catch (Exception)
                {
                    connection.Close();
                    return result;
                }
            }
        }

        public bool Create(IUser user)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"INSERT INTO users(name, password, id_role) Values (@Name, @Password, @Id_Role)";                    
                    var result= connection.Execute(mysql, user);
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

        public bool Update(IUser user)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"UPDATE  users SET name = @Name, password=@Password, id_role=@Id_Role where (id = @Id)";                    
                    var result = connection.Execute(mysql, user);
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

        public bool Delete(IUser user)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"UPDATE  users SET state=0 where (id = @Id)";                   
                    var result = connection.Execute(mysql, user);
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
        
        public IEnumerable<dynamic> GetAll()
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"SELECT * FROM users";
                    var result = connection.Query(mysql).ToList();                                        
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
        
        public bool ReRegister(IUser user)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"UPDATE  users SET state=1 where (id = @Id)";
                    var result = connection.Execute(mysql, user);
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

        public IEnumerable<dynamic> GetActiveUser()
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"SELECT * FROM users Where(state = 1)";
                    var result = connection.Query(mysql).ToList();
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

        public IEnumerable<dynamic> GetInactiveUser()
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"SELECT * FROM users Where(state = 0)";
                    var result = connection.Query(mysql).ToList();
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
