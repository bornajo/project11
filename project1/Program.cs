using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
            Console.Write("Command: ");
        }

        public StRole stRole = new StRole();
        public DevRole devRole = new DevRole();
        public CeoRole ceoRole = new CeoRole();
        public DsnrRole dsnRole = new DsnrRole();
        public PmRole pmRole = new PmRole();




    }
}






