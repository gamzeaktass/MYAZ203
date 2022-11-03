using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ_203_03
{
    class ShoppingCart
    {

        public List<CartItem> Items;
        public int CartId { get; set; }
        public ShoppingCart()
        {
            Items = new List<CartItem>();
        }

        public ShoppingCart(CartItem cartItem)
        {
            Items = new List<CartItem>();
            Add(cartItem);
        }

        public void Add(CartItem cartItem)
        {
            Items.Add(cartItem);
        }

        public double GetBalance()
        {
            double balance = 0;


            foreach (var item in Items)
            {
                balance += item.Quantity * item.Product.Price;
            }
            return balance;
        }

        public void GetList()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }



        public CartItem Remove(int id)
        {
            var crt = Items[id];
            Items.RemoveAt(id);
            return crt;
        }




    }
}

