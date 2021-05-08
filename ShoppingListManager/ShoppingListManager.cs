using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Console;

namespace ShoppingListManager
{
    public class ShoppingListManager
    {
        public void Start()
        {
            LogoFrame logoFrame = new LogoFrame(1, frameheight: 4);
            logoFrame.printLogo();
            Thread.Sleep(3000);
            Console.Clear();

            Logo logo = new Logo();
            string prompt = "Welcome to Shopping List Manager";
            string[] options;
            options = new[] {
                "A  Add a new item", 
                "R  Remove an item", 
                "E  Edit an item", 
                "M  Mark an item as purchased",
                "S  Sort the list",
                "T  Toggle display of purchased items",
                "Q  Quit the program"
                
            };
            Menu mainMenu = new Menu(prompt, options);
            // mainMenu.DisplayOptions();
            int selectedIndex = mainMenu.Run(); 
            // ReadKey(true);
            // WriteLine("Press any key to exit...");

            switch (selectedIndex)
            {
                case 0:
                    //
                    RunFirstChoice();
                    break;
                case 1:
                    //
                    break;
                case 2:
                    //
                    break;
                case 3:
                    //
                    break;
                case 4:
                    //
                    break;
                case 5:
                    //
                    break;
                case 6:
                    //
                    Quit();
                    break;
                default:
                    break;
            }
        }

        private void RunFirstChoice()
        {
            WriteLine("[!] placeholder for the First Choice");
            Quit();
        }
        
        private void AddItem() {}
        
        private void RemoveItem() {}
        
        private void EditItem() {}
        
        private void MarkAsPurchased() {}
        
        private void SortList() {}
        
        private void ToggleDisplay() {}

        private void Quit()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }
    }
}