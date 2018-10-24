using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace project1
{
    public abstract class BaseService<T> where T : RoleProperties, new()
    {
        private readonly string roleName;
        private readonly EmployeeStorage storage;
    


        protected BaseService(string roleName)
        {
            this.roleName = roleName;
            storage = EmployeeStorage.Instance;

        }

        protected EmployeeStorage GetStorageInstance() => storage;
        public virtual T Add()
        {
            T model = new T();





            var valid = false;
            do
            {
                Console.WriteLine("First name");
                valid = Console.ReadLine().IsValidString(out var firstName);
                model.FirstName = firstName;
            } while (!valid);

            do
            {
                Console.WriteLine("Last name");
                valid = Console.ReadLine().IsValidString(out var lastName);
                model.LastName = lastName;
            } while (!valid);

            do
            {
                Console.WriteLine("Age");
                valid = Console.ReadLine().IsValidInt(out var age);
                int age1 = age;
  
            } while (!valid);

            model.Roles = roleName;

            model = AddSpecific(model);

            return storage.Add(model) as T;
        }

        public virtual IEnumerable<T> Find()
        {
            var result = storage.Find(roleName).Cast<T>().ToList();

            if (result != null && result.Any())
            {
                DisplayList(result);
            }

            return result;
        }

        protected IEnumerable<RoleProperties> FindAll()
        {
            return storage.FindAll();
        }

        public virtual T Get(string LastName)
        {
            var result = storage.Get(LastName, roleName) as T;

            if (result != null)
            {
                DisplaySingle(result);
            }

            return result;
        }

        public virtual bool Remove(string LastName)
        {
            var existingEmployee = Get(LastName);

            return existingEmployee != null && storage.Remove(existingEmployee);
        }


        protected abstract T AddSpecific(T model);

     
        protected abstract void DisplayList(IEnumerable<T> list);

  
        protected abstract void DisplaySingle(T model);

    }
}