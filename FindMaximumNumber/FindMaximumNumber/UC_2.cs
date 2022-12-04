using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class UC_2
    {
        public static double MaximumNumbers(double firstValue, double secondValue, double thirdValue)
        {
            if( firstValue.CompareTo(secondValue)>0 && firstValue.CompareTo(thirdValue)>0 )
            {
                return firstValue;

            }
            if(secondValue.CompareTo(thirdValue)>0 && secondValue.CompareTo(firstValue)>0 )
            {
                return secondValue;
            }
            if(thirdValue.CompareTo(firstValue)>0 && thirdValue.CompareTo(secondValue)>0 )
            {
                return thirdValue;
            }
                throw new Exception("firstValue,secondValue,thirdValue are the same");

        }
    }
}
