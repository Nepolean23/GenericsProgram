using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class UC_3
    {
        public static string MaximumStringNumbers(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
              firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
              firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }
            if (secondString.CompareTo(thirdString) > 0 && secondString.CompareTo(firstString) > 0 ||
              secondString.CompareTo(thirdString) >= 0 && secondString.CompareTo(firstString) > 0 ||
              secondString.CompareTo(thirdString) > 0 && secondString.CompareTo(firstString) >= 0)
            {
                return secondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
              thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
              thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }
            throw new Exception("firstString,secondString,thirdString are the same");
        }
    }
}
