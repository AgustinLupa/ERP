using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Data;
using SystemERP.Model;
using SystemERP.Utils;

namespace SystemERP.Controller
{
    public class EmployeeController
    {
        private EmployeeData data = new EmployeeData();
        private IEnumerable<Employee> employees = new List<Employee>();


        public int CreateEmployee(string name, string lastname, int dni, int code_employee)
        {
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastname) || dni <= 10000000 || code_employee ==0)
            {
                return 0;
            }
            if(!SpecialCharacters.ContainsSpecialCharacters(name) || !SpecialCharacters.ContainsSpecialCharacters(lastname))
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

        public void SetListEmployee(IEnumerable<Employee> employees)
        {            
            this.employees = employees;
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

        private IEnumerable<Employee> GetEmployeeByName(string name)
        {
            var filteredEmployee = employees
                .Where(employee => employee.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                .Select(employee => employee);
            return filteredEmployee;
        }

        private IEnumerable<Employee> GetEmployeeByDNI(string dni)
        {
            var filteredEmployee = employees
               .Where(employee => Convert.ToString(employee.Dni).IndexOf(dni, StringComparison.OrdinalIgnoreCase) >= 0)
               .Select(employee => employee);
            return filteredEmployee;
        }

        private IEnumerable<Employee> GetEmployeeByLastName(string lastName)
        {
            var filteredEmployee = employees
                .Where(employee => employee.LastName.IndexOf(lastName, StringComparison.OrdinalIgnoreCase) >= 0)
                .Select(employee => employee);
            return filteredEmployee;
        }

        public IEnumerable<Employee> FilterList(string filterType, string filterText)
        {                                
            if (filterType == "NOMBRE")
            {                
                return GetEmployeeByName(filterText);
            }
            if (filterType == "DNI")
            {                
                return GetEmployeeByDNI(filterText);
            }
            if(filterType == "APELLIDO")
            {                
                return GetEmployeeByLastName(filterText);
            }
            return employees;
        }

        public IEnumerable<Employee> GetListActive()
        {
            return this.employees;
        }

        public bool EmployeeActiveByCode(int code)
        {
            return employees.Any(e => e.Code_Employee == code);
        }

        public bool DeleteEmployee(Employee code)
        {
            var result = data.DeleteEmployee(code);
            if (result >0)
            {
                return true;
            }
            return false;
        }
    }
}
