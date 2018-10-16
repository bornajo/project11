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

            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
            while (true)
            {

                Console.Write("Command: ");
                var command = Console.ReadLine();

                if (command.ToLower() == "add")
                {
                    Console.Write("Role: ");
                    var role = Console.ReadLine();
                    //var ndceo = Storage.Instance.MyList.Where(roles => roles.Role == "ceo").FirstOrDefault();
                    switch (role.ToLower())
                    {
                        case "ceo":
                            if (ndceo == null)
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
                }
                else if (command.ToLower() == "remove")
                {
                    
                }
            }
        }

    }

}





