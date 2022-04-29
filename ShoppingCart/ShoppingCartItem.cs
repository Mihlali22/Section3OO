using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    
    public class ShoppingCartItem 
    {
        public string CartItem { get; private set; }
        public double Price { get; private set; }

        public ShoppingCartItem(string cartItem, double price)
        {
            CartItem = cartItem;
            Price = price;
        }



    }
}
