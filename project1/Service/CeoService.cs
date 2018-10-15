using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
   public class CeoService : BaseService<CeoRole>
   {
       public override void AddSpecific(CeoRole item)
       {
            // CeoRole model = new CeoRole();
           item.Role = "ceo";
           Console.Write("CEOYears: ");
           item.CeoYears = Convert.ToInt32(Console.ReadLine());
       }
       public override void Display()
       {

       }
   }
}