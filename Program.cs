using System;

namespace Test_Maximum_Using_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("1. Find the maximum integer.");
                Console.WriteLine("2. Find the maximum float.");
                Console.WriteLine("3. Find the maximum string.");
                Console.Write("=> ");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        // TC 1.1 - Max Number at first position
                        int maxFirstInt = FindMaxInt.MaxInteger(45, 12, 3);
                        Console.WriteLine("{0} is the maximum number at first position", maxFirstInt);

                        // TC 1.2 - Max Number at second position
                        int maxSecondInt = FindMaxInt.MaxInteger(12, 34, 2);
                        Console.WriteLine("{0} is the maximum number at second position", maxSecondInt);

                        // TC 1.3 -  Max Number at third position
                        int maxThirdInt = FindMaxInt.MaxInteger(3, 9, 19);
                        Console.WriteLine("{0} is the maximum number at third position", maxThirdInt);
                        break;

                    default:
                        Console.WriteLine("Enter valid option.");
                        break;

                }

            }

        }
    }
}