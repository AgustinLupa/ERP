using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemERP.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int State { get; set; }
        public int Dni { get; set; }
        public int Code_Employee { get; set; }

        public override string ToString()
        {
            return $"|Nombre: {Name} | Apellido: {LastName} | Dni: {Dni} | Codigo Empleado: {Code_Employee}";
        }
    }
}
