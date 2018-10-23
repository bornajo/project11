using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class DeveloperService : BaseService<DevRole>
    {
        public DeveloperService() : base(Common.Roles.Developer)
        {
        }

        protected override DevRole AddSpecific(DevRole model)
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
                valid = Console.ReadLine().IsValidBool(out var isStudent);
                model.IsStudent = isStudent;
            } while (!valid);

            return model;
        }

        protected override void DisplayList(IEnumerable<DevRole> list)
        {
            foreach (var item in list)
            {
                DisplaySingle(item);
            }
        }

        protected override void DisplaySingle(DevRole model)
        {
            Console.WriteLine($"{model.Id}: {model.LastName} {model.FirstName}, {model.Age}, works on {model.Project} project {(model.IsStudent ? "is" : "is not")} a student");
        }
    }
}

