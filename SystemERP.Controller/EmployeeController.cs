using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Data;
using SystemERP.Model;

namespace SystemERP.Controller
{
    public class EmployeeController
    {
        private EmployeeData data = new EmployeeData();
        private IEnumerable<Employee> employees = new List<Employee>();

        public int CreateEmployee(string name, string lastname, int dni, int code_employee)
        {
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastname) || dni <= 10000000)
            {
                return 0;
            }           
            Employee employee = new Employee() {
                Code_Employee = code_employee,
                Name = name.ToUpper(),
                Dni = dni,
                LastName = lastname.ToUpper()
            };
            return data.CreateEmployee(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            return data.GetAll();
        }

        public void SetEmployee()
        {
            this.employees = GetAll();
        }

        public Employee GetByCode(int code)
        {
            if (code <=0)
                return 0;
            return data.GetByCode(code);
        }

        public IEnumerable<Employee> GetActive()
        {
            return data.GetActiveEmployee();
        }
    }
}
