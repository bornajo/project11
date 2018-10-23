using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class RoleFactory
    {
        public RoleProperties Create(string roleName)
        {
            switch (roleName)
            {
                case Common.Roles.Ceo:
                    return new CeoRole();
                case Common.Roles.ProjectManager:
                    return new PmRole();
                case Common.Roles.Developer:
                    return new DevRole();
                case Common.Roles.Designer:
                    return new DsnrRole();
                case Common.Roles.SoftwareTester:
                    return new StRole();
                default:
                    return new RoleProperties();
            }
        }
    }
}