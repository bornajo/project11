using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class PmService : BaseService<PmRole>
    {
        public override void AddSpecific(PmRole item)
        {
            item.Role = "pmrole";
            Console.Write("Projects: ");
            item.Project = Console.ReadLine();
        }

        public override void Display()
        {

        }
    }
}