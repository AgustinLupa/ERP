using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Model;

namespace SystemERP.Data
{
    public class EmployeeData
    {
        public Employee GetByCode(int code_Employee)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"SELECT id, name, lastname, state, dni, code_employee FROM employee where (code_employee = @code_Employee)";
                    Employee result = connection.QuerySingleOrDefault<Employee>(mysql, new { code_Employee });
                    connection.Close();
                    return result;
                }
                catch (Exception)
                {
                    connection.Close();
                    return new Employee();
                }
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"SELECT id, name, lastname, state, dni, code_employee FROM employee";
                    IEnumerable<Employee> result = connection.Query<Employee>(mysql);
                    connection.Close();
                    return result;
                }
                catch (Exception)
                {
                    connection.Close();
                    return new List<Employee>();
                }
            }
        }

        public IEnumerable<Employee> GetActiveEmployee()
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"SELECT id, name, lastname, state, dni, code_employee FROM employee where (state = 1)";
                    IEnumerable<Employee> result = connection.Query<Employee>(mysql);
                    connection.Close();
                    return result;
                }
                catch (Exception)
                {
                    connection.Close();
                    return new List<Employee>();
                }
            }
        }

        public int CreateEmployee(Employee employee)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"INSERT INTO employee(name, lastname, dni, code_employee) 
                                  Values (@Name, @LastName, @Dni, @Code_Employee);";
                    var result = connection.Execute(mysql, employee);
                    connection.Close();
                    return result;
                }
                catch (Exception)
                {
                    connection.Close();
                    return 0;
                }
            }
        }        

    }
}
