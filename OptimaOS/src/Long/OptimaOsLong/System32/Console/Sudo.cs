using System;
using System.Collections.Generic;
using System.Text;
using OptimaOs;

namespace OptimaOs.System32.Consol
{
    class Sudo
    {
        public static void Start()
        {
            string[] xinput = Kernel.input.Split(' ');
            if (xinput.Length == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                if(xinput[0] == "change")
                {
                    if (xinput.Length == 1)
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        if(xinput[1] == "name-os")
                        {
                            if (xinput.Length == 2)
                            {
                                Console.WriteLine("error");
                            }
                            else
                            {
                                Console.WriteLine("name before change: " + Settings.name_os);
                                Settings.name_os = xinput[2];
                                Console.WriteLine("name after change: " + Settings.name_os);
                            }
                        }
                        else if (xinput[1] == "user")
                        {
                            if (xinput.Length == 2)
                            {
                                Console.WriteLine("error");
                            }
                            else
                            {
                                Console.WriteLine("name before change: " + Settings.name_user);
                                Settings.name_user = xinput[2];
                                Console.WriteLine("name after change: " + Settings.name_user);
                            }
                        }
                    }
                }
                else if(xinput[0] == "format-disk")
                {
                    if (xinput.Length == 1)
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        Console.WriteLine("format the disk?[y-yes, n-no]");
                        char inp = Console.ReadKey().KeyChar;
                        if (inp == 'y')
                        {
                            Console.Clear();
                            var fs = new Cosmos.System.FileSystem.CosmosVFS();
                            Cosmos.System.FileSystem.VFS.VFSManager.RegisterVFS(fs);
                            if (Cosmos.System.FileSystem.VFS.VFSManager.IsValidDriveId(xinput[1]))
                            {
                                fs.Format(xinput[1], "FAT32", true);
                            }
                            else
                            {
                                Console.WriteLine("ti chto takogo pyti net");
                            }
                        }
                        else if (inp == 'n')
                        {
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("error: you pressed the wrong button");
                        }
                    }
                }
            }
        }
    }
}
