using System;
using System.Threading;

namespace ShoppingListManager
{
    class Program
    {
        // static Frame frame = new Frame(5);
        
        static void Main(string[] args)
        {
            ShoppingListManager shoppingListManager = new ShoppingListManager();
            shoppingListManager.Start();
        }
    }
}