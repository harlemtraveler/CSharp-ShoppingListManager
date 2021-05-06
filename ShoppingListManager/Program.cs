using System;

namespace ShoppingListManager
{
    class Program
    {
        static Frame frame = new Frame(5);
        
        // Must find a way to pass content into the center of the Frame
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Frame frame1 = new Frame();
            frame.CreateFrame();
        }
    }
}