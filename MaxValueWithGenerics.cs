using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Maximum_Using_Generics
{
    internal class MaxValueWithGenerics<T> where T : IComparable<T>
    {
        // Use generic method and find the maximum value
        public static T MaxValue(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else
            {
                return third;
            }
        }
    }
}
