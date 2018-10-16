using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project1
{
    public class Storage
    {
        protected static Storage instance;
        private Storage() { }
        public static Storage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Storage();
                }
                return instance;
            }
        }


        private List<RoleProperties> MyList = new List<RoleProperties>();

        public void Help()
        {
            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
        }



        public void Add(RoleProperties item)
        {
            MyList.Add(item);
        }

        public void Remove(RoleProperties item)
        {
            MyList.Remove(item);
        }

        public void Display()
        {
            foreach (RoleProperties role in Storage.Instance.MyList)
            {
                Console.WriteLine("Role: {0}, First name: {1}, Last name: {2}, Age: {3}", role.Role,
                    role.FirstName, role.LastName, role.Age);
            }


        }
        public void List()
        {
            foreach (RoleProperties role in MyList.FindAll(item => item.Role != "ceo")) ;
        }
        public static bool CheckCeoExist()
        {
            var ceoExistance=Storage.Instance.MyList.Where(roles => roles.Role == "ceo").FirstOrDefault();
            return 
        }

    }
}
