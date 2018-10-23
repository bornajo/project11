using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace project1
{
    public abstract class BaseService<T> where T : RoleProperties
    {
        private readonly string roleName;
        private readonly EmployeeStorage storage;
        private readonly RoleFactory roleFactory;


        protected BaseService(string roleName)
        {
            this.roleName = roleName;
            storage = EmployeeStorage.Instance;
            roleFactory = new RoleFactory();
        }

        protected EmployeeStorage GetStorageInstance() => storage;

        public virtual T Add()
        {
            var model = roleFactory.Create(roleName) as T; // cast is required because of AddSpecific(model) method

            model.Id = UniqueIdentifierGenerator.Instance.GetUniqueId();

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

            model.Role = roleName;

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

        public virtual T Get(int id)
        {
            var result = storage.Get(id, roleName) as T;

            if (result != null)
            {
                DisplaySingle(result);
            }

            return result;
        }

        public virtual bool Remove(int id)
        {
            var existingEmployee = Get(id);

            return existingEmployee != null && storage.Remove(existingEmployee);
        }

        /// <summary>
        /// Implement role specific value binding
        /// </summary>
        /// <param name="model">Model with generic value binding.</param>
        /// <returns>Role model with all data</returns>
        protected abstract T AddSpecific(T model);

        /// <summary>
        /// Implement to display role specific employee data
        /// </summary>
        /// <param name="list">List with role employees</param>
        protected abstract void DisplayList(IEnumerable<T> list);

        /// <summary>
        /// Implement to display single role specific employee data
        /// </summary>
        /// <param name="model">Model with employee data</param>
        protected abstract void DisplaySingle(T model);

    }
}