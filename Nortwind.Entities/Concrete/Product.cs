using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string  ProductName { get; set; }
        public Int32 CategoryId { get; set; }
        public decimal UnitPrace { get; set; }
        public string  QuantityPerUnit { get; set; }
        public Int16 UnitsInStock { get; set; }
    }
}
