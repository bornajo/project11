using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class StService : BaseService<StRole>
    {
        public StService() : base(Common.Roles.SoftwareTester)
        {
        }

        protected override StRole AddSpecific(StRole model)
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
                Console.WriteLine("Is he/she using automated tests?");
                valid = Console.ReadLine().IsValidBool(out var usesAutomatedTests);
                model.UsesAutomatedTests = usesAutomatedTests;
            } while (!valid);

            return model;
        }

        protected override void DisplayList(IEnumerable<StRole> list)
        {
            foreach (var item in list)
            {
                DisplaySingle(item);
            }
        }

        protected override void DisplaySingle(StRole model)
        {
            Console.WriteLine($"{model.Roles}: {model.LastName} {model.FirstName}, {model.Age}, works on {model.Project} project and {(model.UsesAutomatedTests ? "is" : "isn't")} using automated tests");
        }
    }
}
