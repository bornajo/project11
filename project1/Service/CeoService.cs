using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
   public class CeoService : BaseService<CeoRole>
   {
       public override void AddSpecific(CeoRole item)
       {
           item.Role = "ceo";
            item.CeoYears = Helper.ParseUserInput("CeoYears: ");
       }
       public override void Display()
       {

       }
        public bool SearchCeo()
        {
            bool searchCeo = Storage.Instance.CheckIfCeoExist();
            return searchCeo;
        }
      
    }
}