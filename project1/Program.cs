using System;
using System.Collections.Generic;
using System.Linq;
namespace project1
{
    class Program
    {
        private static string role;

        static void Main(string[] args)
        {
            CeoService ceoService = new CeoService("ceo");
            StService stService = new StService("st");
            PmService pmService = new PmService("pm");
            DsnrService dsnService = new DsnrService("dns");
            DevService devService = new DevService("dev");
            CommonService commonService = new CommonService();
            var valid = false;
            string command;
            do
            {
                Console.WriteLine("Command: ");
                command = Console.ReadLine();
                valid = CommandValidator.IsValidCommand(command);
                command = command.ToUpper();
                while (true)
                {
                    Console.Write("Command: ");
                    if (Console.ReadLine().ToLower() == "add")
                    {
                        do
                        {
                            Console.Write("Role: ");
                            role = Console.ReadLine();
                        }
                        while (role.ToLower() != "ceo" && role.ToLower() != "pm" && role.ToLower() != "dev" && role.ToLower() != "dsn" && role.ToLower() != "st");
                        switch (role.ToLower())
                        {
                            case "ceo":
                                if (ceoService.SearchCeo() == false)
                                {
                                    ceoService.Add();
                                }
                                else
                                {
                                    Console.WriteLine("There is already one CEO.");
                                }
                                break;
                            case "pm":
                                pmService.Add();
                                break;
                            case "st":
                                stService.Add();
                                break;
                            case "dsn":
                                dsnService.Add();
                                break;
                            case "dev":
                                devService.Add();
                                break;

                        }

                        Console.WriteLine("Possible commands are:");
                        Console.WriteLine("-- Add");
                        Console.WriteLine("---- will route you to add a new employee");
                        Console.WriteLine("-- Remove");
                        Console.WriteLine("---- will route you to remove existing employee");
                        Console.WriteLine("-- Display");
                        Console.WriteLine("---- will display all employees including you");
                        Console.WriteLine("-- List");
                        Console.WriteLine("---- will display all employees excluding you");
                        Console.WriteLine("-- <role>List");
                        Console.WriteLine("---- will display role specific employees. Example: CeoList, PmList");

                    }
                }
            }
        }
    }
}






