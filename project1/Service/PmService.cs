﻿using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class PmService : BaseService<PmRole>
    {
        public PmService() : base(Common.Roles.ProjectManager)
        {
        }

        protected override ProjectManagerRole AddSpecific(ProjectManagerRole model)
        {
            bool valid;
            do
            {
                Console.WriteLine("What project is he/she working on?");
                valid = Console.ReadLine().IsValidString(out var project);
                model.Project = project;
            } while (!valid);

            return model;
        }

        protected override void DisplayList(IEnumerable<ProjectManagerRole> list)
        {
            foreach (var item in list)
            {
                DisplaySingle(item);
            }
        }

        protected override void DisplaySingle(PmRole model)
        {
            Console.WriteLine($"{model.Id}: {model.LastName} {model.FirstName}, {model.Age}, works on {model.Project} project");
        }
    }
}