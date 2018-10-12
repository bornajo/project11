using project1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class PmService : BaseService<PmRole>
    {
        public override void AddSpecific(PmRole item)
        {
            // PmRole model = new PmRole();
            Console.Write("Projects: ");
            item.Project = Console.ReadLine();
        }

        public override void Display()
        {

        }
    }
}