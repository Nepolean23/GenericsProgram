using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class UC_1
    {
        public static int MaximumIntengersNumbers(int firstValue,int secondValue,int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue)>0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue)>0 && thirdValue.CompareTo(secondValue)>0)
            {
                return thirdValue;
            }
            throw new Exception("firstVlaue,secondValue,thirdVlaue are the same");
              


                    
            

        }
    }
}
