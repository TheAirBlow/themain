using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;
using OptimaOs.System32;
using OptimaOs.System32.Consol;

namespace OptimaOs
{
    public class Kernel : Sys.Kernel
    {
        public static string input;
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("The system has started");
        }

        protected override void Run()
        {
            if (Settings.sudos)
            {
                Console.Write("Sudo@" + Settings.name_user + " > ");
            }
            else
            {
                Console.Write("@" + Settings.name_user + " > ");
            }
            input = Console.ReadLine();
            if (Settings.sudos)
            {
                Sudo.Start();
            }
            else
            {
                Commands.Start();
            }
            if(input == "sudo")
            {
                Settings.sudos = !Settings.sudos;
            }
        }
    }
}
