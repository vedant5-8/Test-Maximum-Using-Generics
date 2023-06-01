using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test_Maximum_Using_Generics
{
    internal class FindMoreMaxValues
    {
        // Extend the max method to take more then three parameters
        public static T FindMaximum<T>(params T[] values) where T : IComparable<T>
        {
            T max = values[0];

            for(int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }

            return max;
        }
    }
}
