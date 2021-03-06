using System;

namespace ShoppingListManager
{
    public class LogoFrame : Frame
    {
        public int listlength { get; set; }
        string Title = "Welcome to the Shopping List Manager";
        public int ItemsCount = 6;
        public string Subtitle { get; set; }
        int counter = 1;
        
        public LogoFrame() : base() {}

        public LogoFrame(int listlength, int frameheight = 4) : base(frameheight)
        {
            this.listlength = listlength;
            this.Subtitle = "You have " + ItemsCount.ToString() + " items in your list";
        }

        public void printLogo() // add frame side here, with each WriteLine command
        {
            // Console.WriteLine("");
            while (counter <= frameheight)
            {
                if (counter == 1 || counter == frameheight)
                {
                    int index = 1;
                    while (index <= FrameLength)
                    {
                        Console.Write(star);
                        index++;
                    }
                }
                else if (counter == 2)
                {
                    // Console.WriteLine("Welcome to the Shopping List Manager");
                    Console.WriteLine("{0, -25} {1, -50} {2, 23}", star, Title, star);
                }
                else if (counter == 3)
                {
                    Console.WriteLine("{0, -25} {1, -50} {2, 23}", star, Subtitle, star);
                }
                
                Console.WriteLine(" ");
                counter++;
            }

            // Console.ReadLine();
        }
    }
}