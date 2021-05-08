using System;

namespace ShoppingListManager
{
    public class Logo : Frame
    {
        public int listlength { get; set; }
        string Title = "Shopping List Manager";
        public int ItemsCount = 6;
        public string Subtitle { get; set; }
        int counter = 1;

        public Logo()
        {
        }

        public Logo(int listlength) : base(frameheight: 4)
        {
            this.listlength = listlength;
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

                Console.WriteLine(" ");
                counter++;
            }
        }
    }
}