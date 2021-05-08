using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Console;

namespace ShoppingListManager
{
    public class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;
        
        public Menu() {}

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }

        public void DisplayOptions()
        {
            WriteLine(Prompt);

            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix = null;

                if (i == SelectedIndex)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                    // ResetColor();
                }
                
                WriteLine($"{prefix} {currentOption}");
            }
            ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();
                
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                
                // update SelectedIndex based on arrow keys
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);
            
            return SelectedIndex;
        }
    }
}

/*
 * A    Add a new item
 * R    Remove an item
 * E    Edit an item
 * P    Mark an item as purchased
 * S    Sort the list
 * T    Toggle display of purchased items
 * Q    Quit the program
 *
 * Your Choice: ___
 */