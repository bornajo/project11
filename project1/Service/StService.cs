using project1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class StService : BaseService<StRole>
    {
        public override void AddSpecific(StRole item)
        {
            //  StrRole model = new StrRole();
            Console.Write("PROJECT: ");
            item.Project = Console.ReadLine();
            Console.Write("AutomatedTests: ");
            item.AutomatedTests = Console.ReadLine();
        }

        public override void Display()
        {

        }
    }
}