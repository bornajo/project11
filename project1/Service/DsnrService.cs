using project1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class DsnrService : BaseService<DsnrRole>
    {
        public override void AddSpecific(DsnrRole item)
        {
            // DsnrRole model = new DsnrRole();
            Console.Write("Project: ");
            item.Project = Console.ReadLine();
            Console.Write("CanDraw: ");
            item.CanDraw = Console.ReadLine();
        }

        public override void Display()
        {

        }
    }
}