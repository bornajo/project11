using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class DsnrService : BaseService<DsnrRole>
    {

        public DsnrService(string role) : base(role);
        {
        }
    public override void AddSpecific(DsnrRole item)
    {

        item.Role = "dsnrole";
        Console.Write("Project: ");
        item.CanDraw = Helper.ParseBoolInput("CanDraw");
    }

    public override void Display()
    {

    }
}
}
}