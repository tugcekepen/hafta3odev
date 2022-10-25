using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3odev
{
    public class ShoppingCart
    {
        public List<CartItem> CartItems { get; set; }

        public ShoppingCart()
        {
            CartItems = new List<CartItem>();
        }
        public void Add(CartItem item)
        {
            CartItems.Add(item);
        }

        public void GetBalance(int quantity, decimal price)
        {
            decimal total = quantity * price;
            Console.WriteLine("Total pay: " + total);
        }
        public void GetList()
        {
            foreach (var item in CartItems)
            {
                Console.WriteLine($"{item.CartId, -3} {item.Product, -15} {item.Quantity, -5}" );
            }
        }
        public void Remove(int id)
        {
            var cartitem = CartItems
                .Where(ci => ci.CartId == id)
                .FirstOrDefault();
            CartItems.Remove(cartitem);
        }
    }
}
