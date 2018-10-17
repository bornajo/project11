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
        public bool CheckIfCeoExist()
        {
            bool ceoExistance;
            var ceoExistanceCheck = MyList.Where(roles => roles.Role == "ceo").FirstOrDefault();
            if (ceoExistanceCheck == null)
            {
                ceoExistance = false;
            }
            else
            {
                ceoExistance = true;
            }
            return ceoExistance;
        }
        public void RoleNameList()
        {
            Console.Write("Enter role name of employees you want to display: ");
            string roleName = Console.ReadLine();

            foreach (RoleProperties roleNameListItem in MyList.Where(item => item.Role == roleName))
            {
                Console.WriteLine("Role: {0}, First name: {1}, Last name: {2}, Age: {3}", roleNameListItem.Role,
                    roleNameListItem.FirstName, roleNameListItem.LastName, roleNameListItem.Age);
            }

        }
    }
}