using System;
using System.Collections.Generic;
using System.Text;
using OptimaOs.System32.Consol;

namespace OptimaOs.System32.Programs
{
    class Calculator
    {
        public static string name_app = "CALCULATOR";
        public static string version_app = "v0.1";
        public static void Start()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if(input.Length < 3)
                {
                    if (input[0] == "exit")
                    {
                        break;
                    }
                    else if(input[0] == "info")
                    {
                        Console.WriteLine("Name app: " + name_app);
                        Console.WriteLine("Version: " + version_app);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if(input.Length == 3)
                {
                    int i1 = Convert.ToInt32(input[0]);
                    int i2 = Convert.ToInt32(input[2]);
                    char cin = Convert.ToChar(input[1]);
                    if (i1 >= 100000)
                    {
                        //Console.WriteLine("error");
                        if (i2 >= 100000)
                        {
                            BsoD.Start("0x0032", name_app, false);
                        }
                        else
                        {
                            BsoD.Start("0x0032", name_app, false);
                        }
                    }
                    else
                    {
                        if (cin == '*')
                        {
                            Console.WriteLine(i1 * i2);
                        }
                        else if (cin == '-')
                        {
                            Console.WriteLine(i1 - i2);
                        }
                        else if (cin == '+')
                        {
                            Console.WriteLine(i1 + i2);
                        }
                        else if (cin == '/')
                        {
                            if (i1 <= 0 || i2 <= 0)
                            {
                                BsoD.Start("0x0000", name_app, true);
                            }
                            else
                            {
                                Console.WriteLine(i1 / i2);
                            }
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}