using System;
using System.Collections.Generic;
using System.Linq;
namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new EmployeeService();

            HandleHelp();

            string command;
            do
            {
                Console.Write("Command: ");
                command = Console.ReadLine();
                command = command.ToUpper();
                switch (command)
                {
                    case Commands.Add:
                        service.HandleAdd();
                        break;
                    case Commands.Remove:
                        service.HandleRemove();
                        break;
                    case Commands.Display:
                        service.HandleDisplay();
                        break;
                    case Commands.List:
                        service.HandleList(null);
                        break;
                    case Commands.CeoList:
                    case Commands.PmList:
                    case Commands.DevList:
                    case Commands.DsnrList:
                    case Commands.StList:
                        var role = command.Replace("LIST", "");
                        service.HandleList(role);
                        break;
                    case Commands.Help:
                        HandleHelp();
                        break;
                    case Commands.Exit:
                        Console.WriteLine("Bye bye");
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        HandleHelp();
                        break;
                }
            } while (command != Commands.Exit);
        }

        static void HandleHelp()
        {
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




