using System;

namespace ShoppingListManager
{
    public class LogoFrame
    {
        public int listlength { get; set; }
        
        public LogoFrame() {}

        public LogoFrame(int listlength)
        {
            this.listlength = listlength;
        }

        public static void printLogo()
        {
            Console.WriteLine("Welcome to the Shopping List Manager");
        }
    }
}