using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemERP.Model
{
    public class CashRegister
    {
        public int Id { get; set; }
        public double Ini_Amount { get; set; }
        public double Final_Amount { get; set; }
        public DateTime OpenDate { get; set; } = DateTime.Now;
        public DateTime CloseDate { get; set; }
        public int Transaction_Count { get; set; }
        public Employee Employee { get; set; }
        public double Current_Balance { get; set; }
    }
}
