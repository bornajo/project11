using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class StService : BaseService<StRole>
    {
        public override void AddSpecific(StRole item)
        {
            //  StrRole model = new StrRole();
            item.Role = "st";
            Console.Write("Project: "); ;
            item.Project = Console.ReadLine();
            Console.Write("AutomatedTests: ");
            item.AutomatedTests = Helper.ParseBoolInput("UsesAutomatedTest:");
        }

        public override void Display()
        {

        }
    }
}