using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
            //Console.ReadLine();
            //Console.Write("Role:");
            //String Role = Console.ReadLine();
            //Console.Write("FirstName:");
            //String FirstName = Console.ReadLine();
            //Console.Write("LastName:");
            //String LastName = Console.ReadLine();
            //Console.Write("Age:");
            //String Age = Console.ReadLine();
            //Console.ReadLine();

            var martina = new Person();

            martina.FirstName = Console.ReadLine();

            string test = martina.FirstName;

        }

    }

    public class Person
    {
        public string  FirstName { get; set; }
    }
}



