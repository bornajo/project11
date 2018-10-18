using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class CommonService 
    {
        public void FindAll()
        {

        }
        public void Get()
        {

        }
        public void Remove (string removeLastName)
        {
            Storage.Instance.Remove(removeLastName);
        }
    }
}