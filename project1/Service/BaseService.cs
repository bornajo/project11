using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public abstract class BaseService<T> where T : RolePropeties, new()
    {
        protected Storage Storage = new Storage();
        public void Add()
        {
            T model = new T();


            Console.Write("FirstName:");
            model.FirstName = Console.ReadLine();
            Console.Write("LastName:");
            model.LastName = Console.ReadLine();
            Console.Write("Age:");
            model.Age = Console.ReadLine();
            Console.ReadLine();

            AddSpecific(model);
            Storage.Add(model);
        }
        public abstract void AddSpecific(T item);
        public abstract void Display();
    }
}
