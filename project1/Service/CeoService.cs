using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace project1
{
    public class CeoService : BaseService<CeoRole>
    {
        public CeoService() : base(Common.Roles.Ceo)
        {
        }

        public override CeoRole Add()
        {
            var existingCeo = Find();

            if (existingCeo != null && existingCeo.Any())
            {
                Console.WriteLine("There can only be one CEO.");
            }
            else
            {
                return base.Add();
            }

            return existingCeo.First();
        }

        protected override CeoRole AddSpecific(CeoRole model)
        {
            bool valid;
            do
            {
                Console.WriteLine("How long are you a CEO(in years)?");
                valid = Console.ReadLine().IsValidInt(out var ceoYears);
                model.CeoYears = ceoYears;
            } while (!valid);

            return model;
        }

        protected override void DisplayList(IEnumerable<CeoRole> list)
        {
            foreach (var item in list)
            {
                DisplaySingle(item);
            }
        }

        protected override void DisplaySingle(CeoRole model)
        {
            Console.WriteLine($"{model.Id}: {model.LastName} {model.FirstName}, {model.Age}, with {model.CeoYears} {(model.CeoYears <= 1 ? "year" : "years")} of experiance as CEO");
        }
    }
}
