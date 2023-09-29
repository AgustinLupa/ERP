using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public void SetListEmployee()
        {
            this.employees = GetAll();
        }

        public Employee GetByCode(int code)
        {
            if (code <=0)
                return new Employee();
            return data.GetByCode(code);
        }

        public IEnumerable<Employee> GetActive()
        {
            return data.GetActiveEmployee();
        }

        //public Employee GetEmployeeByName(string name)
        //{

        //}

        public IEnumerable<Employee> FilterList(string filterType, string filterText)
        {            
                    
            if (filterType == "NOMBRE")
            {
                var filteredEmployee = employees
                .Where(employee => employee.Name.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0)
                .Select(employee => employee);
                return filteredEmployee;
            }
            if (filterType == "DNI")
            {
                var filteredEmployee = employees
                .Where(employee => Convert.ToString(employee.Dni).IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0)
                .Select(employee => employee);
                return filteredEmployee;
            }
            if(filterType == "APELLIDO")
            {
                var filteredEmployee = employees
                .Where(employee => employee.LastName.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0)
                .Select(employee => employee);
                return filteredEmployee;
            }

            return employees;
        }

        public IEnumerable<Employee> GetListActive()
        {
            return this.employees;
        }
    }
}
