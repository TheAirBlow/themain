using System;
using System.Collections.Generic;
using System.Text;
using OptimaOs.System32;

namespace OptimaOs.System32
{
    class BsoD
    {
        public static void Start(string error, string name, bool red)
        {
            if (red)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            Console.Clear();
            Console.WriteLine("Error in the system(" + Settings.name_os + ")");
            Console.WriteLine("Name app: " + name + "\nError code: " + error);
            Console.WriteLine("Do not worry with your computer is not what will not be just press any button on the keyboard or go to our official website");
            //Console.WriteLine("Press any button to restart the system");
            Console.ReadKey();
            Cosmos.System.Power.Reboot();
        }
    }
}
