using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.System.Network;
using Cosmos.System.FileSystem;
using OptimaOs.System32;
using OptimaOs.System32.Programs;

namespace OptimaOs.System32.Consol
{
    class Commands
    {
        public static string dir = "1:\\";
        public static void Start()
        {
            string[] input = Kernel.input.Split(' ');
            if(input.Length == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                if(input[0] == "start")
                {
                    if (input.Length == 1)
                    {
                        Console.WriteLine("error");
                    }
                    else 
                    {
                        if(input[1] == Calculator.name_app)
                        {
                            Calculator.Start();
                        }
                    }
                }
                else if(input[0] == "bsod")
                {
                    BsoD.Start("0x0000", "Test-BsoD", true);
                }
                else if(input[0] == "con")
                {
                    BsoD.Start("0x0000", "CON", false);
                }
                else if(input[0] == "info")
                {
                    Console.WriteLine("Name system: " + Settings.name_os);
                    Console.WriteLine("Name user: " + Settings.name_user);
                    Console.WriteLine("Version system: " + Settings.version_os);
                }
                else if(input[0] == "help")
                {
                    Console.WriteLine("info - all information about the system");
                    Console.WriteLine("bsod - test bsod");
                    Console.WriteLine("start <name app.cs> - launch the app");
                    Console.WriteLine("change <on system> <settings> - change settings");
                }
                else if(input[0] == "create")
                {
                    if(input.Length == 1)
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        var fs = new Cosmos.System.FileSystem.CosmosVFS();
                        Cosmos.System.FileSystem.VFS.VFSManager.RegisterVFS(fs);
                        dir = input[1];
                        fs.CreateFile(dir);
                    }
                }
                else if(input[0] == "reboot")
                {
                    Cosmos.System.Power.Reboot();
                }
                else if(input[0] == "shutdown")
                {
                    Cosmos.System.Power.Shutdown();
                }
                else if(input[0] == "clear")
                {
                    Console.Clear();
                }
            }
        } 
    }
}
