using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public static class RoleValidator
    {
        public static bool IsValidRole(string roleName)
        {
            var valid = !string.IsNullOrEmpty(roleName) &&
                   (string.Equals(roleName, Common.Roles.Ceo, StringComparison.InvariantCultureIgnoreCase) ||
                    string.Equals(roleName, Common.Roles.ProjectManager, StringComparison.InvariantCultureIgnoreCase) ||
                    string.Equals(roleName, Common.Roles.Developer, StringComparison.InvariantCultureIgnoreCase) ||
                    string.Equals(roleName, Common.Roles.Designer, StringComparison.InvariantCultureIgnoreCase) ||
                    string.Equals(roleName, Common.Roles.SoftwareTester, StringComparison.InvariantCultureIgnoreCase));

            if (!valid)
            {
                Console.WriteLine("Invalid role name");
                Console.WriteLine("Possible roles are: CEO, PM(Project manager), DEV(Developer), DSNR(Designer), ST(Software tester)");
            }

            return valid;
        }
    }
}
