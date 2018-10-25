using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class EmployeeStorage
    {
        private static EmployeeStorage instance;

        private List<RoleProperties> Storage { get; set; }

        private EmployeeStorage()
        {
            Storage = new List<RoleProperties>();
        }

        public static EmployeeStorage Instance => instance ?? (instance = new EmployeeStorage());

        public RoleProperties Add(RoleProperties role)
        {
            Storage.Add(role);

            return role;
        }


        public IEnumerable<RoleProperties> Find(string roleName)
        {
            if (!string.IsNullOrEmpty(roleName))
            {
                return Storage.Where(e => e.Roles == roleName).ToList();
            }

            return Storage.Where(e => e.Roles != Common.Roles.Ceo).ToList();
        }

        public IEnumerable<RoleProperties> FindAll()
        {
            return Storage.ToList();
        }

        public RoleProperties Get(string Roles, string Role)
        {
            if (string.IsNullOrEmpty(Role))
            {
                return Storage.FirstOrDefault(e => e.Roles == Role);
            }

            return Storage.FirstOrDefault(e => e.Roles == Role);
        }

        public bool Remove(RoleProperties item)
        {
            return item != null && Storage.Remove(item);
        }
    }
}
