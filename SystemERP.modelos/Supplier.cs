using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemERP.Model
{
    public class Supplier
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? State { get; set; }
        public string? Adress { get; set; }
        public int? Phone { get; set; }
        public List<Product> Products { get; set; }
    }
}
