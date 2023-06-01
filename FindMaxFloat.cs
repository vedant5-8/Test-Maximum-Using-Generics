using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Maximum_Using_Generics
{
    internal class FindMaxFloat
    {
        // UC2 - Given three floating numbers, find the maximum
        public static float MaxFloat(float first, float second, float third)
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
