using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3odev
{
    public class Product
    {
        

        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Product(decimal price, int productId, string productName)
        {
            Price = price;
            ProductId = productId;
            ProductName = productName;
        }
    }
}
