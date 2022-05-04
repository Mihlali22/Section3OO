using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShoppingApp
{
    

    public class ShoppingCart
    {
       private List<ShoppingCartItem> _shoppingItems = new List<ShoppingCartItem>();
        private double _vat = 1.15;

        public void AddItem(ShoppingCartItem ShoppingItem)
        {
            _shoppingItems.Add(ShoppingItem);
        }

        public List<ShoppingCartItem>GetShoppingCartItems()
        {
            return _shoppingItems;
        }
        public double getsubtot()
        {
            double subtot = 0;

            foreach (ShoppingCartItem shoppingCartItem in _shoppingItems)
            {
                subtot += shoppingCartItem.Price;
            }
           return subtot;

        }

        public double getSubTotVat()
        {
            double subtotal = getsubtot();
            return Math.Round(subtotal * _vat,2);
        }



    }
}
