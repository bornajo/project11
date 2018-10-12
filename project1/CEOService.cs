using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class CEOService : BaseService<CEORole>
    {
        public override void AddSpecific(CEORole item)
        {
            CEORole model = new CEORole();
            Console.WriteLine("CEOYears: ");
            model.CEOYears = Console.ReadLine();
        }

        public override void Display()
        
        }
    }
}
