using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class CommonService : BaseService<RoleProperties>
    {
        public CommonService() : base(string.Empty)
        {
        }

        // The 'new' keyword hides the FindAll() method of BaseService
        public new IEnumerable<RoleProperties> FindAll()
        {
            return base.FindAll();
        }

        public IEnumerable<RoleProperties> Find(string roleName)
        {
            return GetStorageInstance().Find(roleName);
        }

        protected override RoleProperties AddSpecific(RoleProperties model)
        {
            throw new NotImplementedException();
        }

        protected override void DisplayList(IEnumerable<RoleProperties> list)
        {
            throw new NotImplementedException();
        }

        protected override void DisplaySingle(RoleProperties model)
        {
            throw new NotImplementedException();
        }
    }