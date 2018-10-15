﻿using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public abstract class BaseService<T> where T : RoleProperties, new()
    {
        protected Storage Storage;
        public void Add()
        {
            T model = new T();


            Console.Write("FirstName:");
            model.FirstName = Console.ReadLine();
            Console.Write("LastName:");
            model.LastName = Console.ReadLine();
            Console.Write("Age:");
            model.Age = Console.ReadLine();

            AddSpecific(model);
            Storage.Instance.Add(model);
            
        }
        public abstract void AddSpecific(T item);
        public abstract void Display();
    }
}
