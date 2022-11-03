using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ_203_03
{
    public class Product
    {
        public Product()
        {
        }

        public Product(double price, string productName)
        {
            Price = price;
            ProductName = productName;
        }

        public double Price { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public override string ToString()
        {
            return $"{ProductName} {Price}";
        }

    }
}
