using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class DsnrService : BaseService<DsnrRole>
    {
        public DsnrService() : base(Common.Roles.Designer)
        {
        }

        protected override DsnrRole AddSpecific(DsnrRole model)
        {
            bool valid;
            do
            {
                Console.WriteLine("What project is he/she working on?");
                valid = Console.ReadLine().IsValidString(out var project);
                model.Project = project;
            } while (!valid);

            do
            {
                Console.WriteLine("Is he/she a student?");
                valid = Console.ReadLine().IsValidBool(out var canDraw);
                model.CanDraw = canDraw;
            } while (!valid);

            return model;
        }

        protected override void DisplayList(IEnumerable<DsnrRole> list)
        {
            foreach (var item in list)
            {
                DisplaySingle(item);
            }
        }

        protected override void DisplaySingle(DsnrRole item)
        {
            Console.WriteLine($"{item.Id}: {item.LastName} {item.FirstName}, {item.Age}, works on {item.Project} project {(item.CanDraw ? "can" : "cannot")} draw");
        }
    }
}
