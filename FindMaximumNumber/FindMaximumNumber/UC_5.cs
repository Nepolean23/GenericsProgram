using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class UC_5<T> where T : IComparable
    {
        public T[] value;

        public UC_5(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return value;
        }
        public T MaxValue(params T[] values) 
        {
            var sorted_values=Sort(values);
            return sorted_values[sorted_values.Length-1];
        }
        public T MaxMethod()
        {
            var max= MaxValue(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max=MaxValue(this.value);
            Console.WriteLine( "The Maximum Value is: "+max);
        }
    }
}
