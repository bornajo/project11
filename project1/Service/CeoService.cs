using project1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
   public class CeoService : BaseService<CeoRole>
   {
       public override void AddSpecific(CeoRole item)
       {
          // CeoRole model = new CeoRole();
           Console.Write("CEOYears: ");
           item.CeoYears = Console.ReadLine();
       }

       public override void Display()
       {

       }
   }
}