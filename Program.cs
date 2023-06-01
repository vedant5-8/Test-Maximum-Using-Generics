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
                Console.WriteLine("4. Find the maximum value using Generics Method");
                Console.WriteLine("5. Find the maximum value using Generics Class");
                Console.WriteLine("0. Exit");
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

                    case 3:
                        // TC 1.1 - Max string at first position
                        string maxFirstString = FindMaxString.MaxString("Programming", "Oriented", "Object");
                        Console.WriteLine("{0} is the maximum number at first position", maxFirstString);

                        // TC 1.2 - Max string at second position
                        string maxSecondString = FindMaxString.MaxString("Inheritance", "Interface", "Abstract");
                        Console.WriteLine("{0} is the maximum number at second position", maxSecondString);

                        // TC 1.3 -  Max string at third position
                        string maxThirdString = FindMaxString.MaxString("getter", "encapsulation", "set");
                        Console.WriteLine("{0} is the maximum number at third position", maxThirdString);
                        break;

                    case 4:
                        // TC 1.1 - Max int from among three integers
                        int MaxValue1 = MaxValueWithGenerics.MaxValue(43456, 456876, 367654336);
                        Console.WriteLine("{0} is the maximum number", MaxValue1);

                        // TC 1.2 - Max float from among three float numbers
                        float MaxValue2 = MaxValueWithGenerics.MaxValue(234.567f, 5986.0978f, 1254.6758f);
                        Console.WriteLine("{0} is the maximum float", MaxValue2);

                        // TC 1.3 -  Max string from among three strings
                        string MaxValue3 = MaxValueWithGenerics.MaxValue("Programming", "Oriented", "Object");
                        Console.WriteLine("{0} is the maximum string", MaxValue3);
                        break;

                    case 5:
                        // TC 1.1 - Max int from among three integers
                        int MaxValue4 = MaxGenericClass<int>.MaxValue(43456, 456876, 367654336);
                        Console.WriteLine("{0} is the maximum number", MaxValue4);

                        // TC 1.2 - Max float from among three float numbers
                        float MaxValue5 = MaxGenericClass<float>.MaxValue(234.567f, 5986.0978f, 1254.6758f);
                        Console.WriteLine("{0} is the maximum float", MaxValue5);

                        // TC 1.3 -  Max string from among three strings
                        string MaxValue6 = MaxGenericClass<string>.MaxValue("Programming", "Oriented", "Object");
                        Console.WriteLine("{0} is the maximum string", MaxValue6);
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Enter valid option.");
                        break;

                }

            }

        }
    }
}