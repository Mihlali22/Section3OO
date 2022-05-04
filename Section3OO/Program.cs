using ShoppingApp;
using System;
using System.Collections.Generic;


namespace Section3OO
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            

            ShoppingCartItem shoppingItem = new ShoppingCartItem ("Xbox",5999);
            cart.AddItem(shoppingItem);

            shoppingItem = new ShoppingCartItem("Air", 60);
            cart.AddItem(shoppingItem);

            shoppingItem = new ShoppingCartItem("Sweets", 60);
            cart.AddItem(shoppingItem);

           


            List<ShoppingCartItem> _shoppingItems = cart.GetShoppingCartItems();

            foreach (ShoppingCartItem shoppingCartItem in _shoppingItems)
            {
                Console.WriteLine(shoppingCartItem.CartItem + "\t\t\t" + shoppingCartItem.Price);
            }
            Console.WriteLine("__________________________________");
            Console.WriteLine($"Sub Total:\t\t{cart.getsubtot()}");
            Console.WriteLine($"Sub Total with VAT:\t{cart.getSubTotVat()}");
            Console.WriteLine("__________________________________");






        }
    }
}









