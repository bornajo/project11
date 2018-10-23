using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class UniqueIdentifierGenerator
    {
        private static UniqueIdentifierGenerator instance;

        private int uniqueId;

        private UniqueIdentifierGenerator()
        {
            uniqueId = 0;
        }

        public static UniqueIdentifierGenerator Instance => instance ?? (instance = new UniqueIdentifierGenerator());

        public int GetUniqueId()
        {
            return uniqueId++;
        }
    }
}