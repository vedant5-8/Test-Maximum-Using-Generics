using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test_Maximum_Using_Generics
{
    internal class FindMoreMaxValues<T> where T : IComparable<T>
    {
        // Extend the max method to take more then three parameters
        T max { get; set; }
        public T FindMaximum(params T[] values)
        {
            max = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }

            return max;
        }

        public void printMax()
        {
            Console.WriteLine("The maximum value is " + max);
        }

    }
}
