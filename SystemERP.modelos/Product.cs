using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemERP.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Barcode { get; set; }
        public int state { get; set; }
        public int Id_Stock { get; set; }
        public int Id_Supplier { get; set; }
        public int AcceptDiscount { get; set; }
        public double Price_CostMax { get; set; }
        public double Price_Public { get; set; }
        public double Price_CostActu { get; set; }
    }
}
