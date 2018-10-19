using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Remove(String removeLastName)
        {
            MyList.Remove(MyList.Where(roles => roles.LastName == removeLastName).FirstOrDefault());
        }
        public List<RoleProperties> GetList(string Role)
        {
            List<RoleProperties> result = MyList.FindAll(item => item.Role == Role);
            return result;
        }

        public void Add(RoleProperties item)
        {
            MyList.Add(item);
        }

        public IEnumerable<RoleProperties> FindAll()
        {
            return MyList.ToList();
        }
        public IEnumerable<RoleProperties> Find()
        {
            return MyList.ToList();
        }

    }
}
    

    
