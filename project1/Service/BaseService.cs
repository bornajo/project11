using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public abstract class BaseService<T> where T : RoleProperties, new()
    {   
        public string Role { get; set; }
        public BaseService(string role)
        {
            Role = role;

        }
        protected Storage Storage;
        public void Add()
        {
            T model = new T();


            Console.Write("FirstName:");
            model.FirstName = Console.ReadLine();
            Console.Write("LastName:");
            model.LastName = Console.ReadLine();
            model.Age = Helper.ParseUserInput("Age:");

            AddSpecific(model);
            Storage.Instance.Add(model);

        }

        public IEnumerable<T> Find()
        {
            return Storage.Instance.Find();
        }
        public abstract void AddSpecific(T item);
        public abstract void Display();
    }
}

