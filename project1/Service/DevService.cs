using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class DevService : BaseService<DevRole>
    {
        public DevService(string role) : base(role)
        {
        }

        public override void AddSpecific(DevRole item)
        {
            item.Role = "dev";
            Console.Write("Project: ");
            item.Project = Console.ReadLine();
            item.IsStudent = Helper.ParseBoolInput("IsStudent: ");
        }

        public override void Display()
        {

        }
    }
}


