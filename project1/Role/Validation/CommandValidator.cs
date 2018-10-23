using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public static class CommandValidator
    {
        public static bool IsValidCommand(string command)
        {
            return !string.IsNullOrEmpty(command) &&
                   (string.Equals(command, Commands.List, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(command, Commands.CeoList, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(command, Commands.PmList, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(command, Commands.DevList, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(command, Commands.DsnrList, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(command, Commands.StList, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(command, Commands.Add, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(command, Commands.Remove, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(command, Commands.Help, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
