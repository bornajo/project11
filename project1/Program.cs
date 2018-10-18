using System;
using System.Collections.Generic;
using System.Linq;
namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            CeoService ceoService = new CeoService();
            StService stService = new StService();
            PmService pmService = new PmService();
            DsnrService dsnService = new DsnrService();
            DevService devService = new DevService();
            CommonService commonService = new CommonService();

            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
            while (true)
            {
                string role;
                Console.Write("Command: ");
                var command = Console.ReadLine();

                if (command.ToLower() == "add")
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
                            if (ceoService.SearchCeo()==false)
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

                }
                else if (command.ToLower() == "help") 
                {
                    Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
                }
                else if (command.ToLower() == "display")
                {
                    foreach (RoleProperties displayItem in MyList)
                    {
                        Console.WriteLine("Role: {0}, First name: {1}, Last name: {2}, Age: {3}", displayItem.Role,
                            displayItem.FirstName, displayItem.LastName, displayItem.Age);
                    }
                }
                else if (command.ToLower() == "remove")
                {
                    Console.Write("Enter last name of employee you want to remove from list: ");
                    string removeLastname = Console.ReadLine();
                    commonService.Remove(removeLastname);
                }
                else if(command.ToLower() == "exit")
                {
                    return;
                }

            }             
        }

    }

}





