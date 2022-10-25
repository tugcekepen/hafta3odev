using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3odev
{
    public class CartItem
    {
        public int CartId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public CartItem(int cartId, string product, int quantity)
        {
            CartId = cartId;
            Product = product;
            Quantity = quantity;
        }

    }
}
