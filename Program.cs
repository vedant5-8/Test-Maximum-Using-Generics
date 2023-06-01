﻿using System;

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

                    case 2:
                        // TC 1.1 - Max Float Number at first position
                        float maxFirstFloat = FindMaxFloat.MaxFloat(623.4821f, 428.231f, 9.9271f);
                        Console.WriteLine("{0} is the maximum number at first position", maxFirstFloat);

                        // TC 1.2 - Max Float Number at second position
                        float maxSecondFloat = FindMaxFloat.MaxFloat(123.1231f, 728.0001f, 555.5555f);
                        Console.WriteLine("{0} is the maximum number at second position", maxSecondFloat);

                        // TC 1.3 -  Max Float Number at third position
                        float maxThirdFloat = FindMaxFloat.MaxFloat(10.00001f, 0.51278f, 9287.8310f);
                        Console.WriteLine("{0} is the maximum number at third position", maxThirdFloat);
                        break;

                    default:
                        Console.WriteLine("Enter valid option.");
                        break;

                }

            }

        }
    }
}