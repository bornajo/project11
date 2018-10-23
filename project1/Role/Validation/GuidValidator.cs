using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public static class GuidValidator
    {
        public static bool IsValidGuid(this string input, out Guid result)
        {
            if (Guid.TryParse(input, out var guid))
            {
                result = guid;

                return true;
            }

            result = Guid.Empty;

            return false;
        }
    }
}
