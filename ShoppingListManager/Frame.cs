using System;

/*
 * This is the base of a "Frame" displayed in the command line.
 * - pass this class a number to config the Frame's height.
 * - TODO: pass content to be displayed in center of Frame.
 */


namespace ShoppingListManager
{
    public class Frame
    {
        int FrameLength = 100;
        string star = "*";
        string space = " ";
        int counter = 1;
        public int frameheight { get; set; }
        
        
        
        // TODO: [+] we'll pass the desired Frame height in as a parameter (multiple Frames are used in app)
        
        
        public Frame() {}
        public Frame(int frameheight)
        {
            this.frameheight = frameheight;
        }

        public void CreateFrame()
        {
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
                else
                {
                    int index = 1;
                    while (index <= FrameLength)
                    {
                        if (index == 1 || index == FrameLength)
                        {
                            Console.Write(star);
                        }
                        else // TODO: [!] wrapped content insert here && format position on screen --> use string format, which would be defined in each frame program
                        {
                            Console.Write(space);
                        }

                        index++;
                    }
                }
                
                Console.WriteLine(" ");
                counter++;
            }
            Console.ReadLine();
        }

        
        
        
    }
    
}