/* 
   213047
   All 7 examples as Functions in given code */


using System;

namespace Functionss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling some functions:");
            /*ClassOne.ExploringNumbers();
            ClassTwo.DemoRefDataTypes();
            ClassThree.DemoPointers();
            ClassFour.CastIntAndDoubles();
            ClassFive.ConvertToString();*/
            ClassSix.ParseToNumbersAndDates();
        }
    }


    class ClassOne
    {
        public static void ExploringNumbers()
        {
            Console.WriteLine("ClassOne - ExploringNumbers");
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range:\n\n" + $"{int.MinValue:N0} to {int.MaxValue:N0}.\n");

            Console.WriteLine("___________________________________________________________");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range:\n\n" + $"{double.MinValue:N0} to {double.MaxValue:N0}.\n");


            Console.WriteLine("___________________________________________________________");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range:\n\n" + $"{decimal.MinValue:N0} to {decimal.MaxValue:N0}.\n");
        }
    }

    class ClassTwo
    {

        public static void DemoRefDataTypes()
        {
            Console.WriteLine("ClassTwo - DemoRefDataTypes");
            String a = "Salam";
            a += "For";

            a = a + "All";
            Console.WriteLine(a);

            object obj;
            obj = 20;
            Console.WriteLine(obj);
            Console.WriteLine(obj.GetType());

        }
    }

    class ClassThree
    {
        public static void DemoPointers()
        {
            Console.WriteLine("ClassThree - DemoPointers");
            unsafe
            {
                int n = 10;
                int* p = &n;

                Console.WriteLine("Value :{0}", n);
                Console.WriteLine("Address :{0}", (int)p);
            }
        }
    }


    class ClassFour
    {
        public static void CastIntAndDoubles()
        {
            Console.WriteLine("ClassFour - CastIntAndDoubles");
            int a = 10;
            double b = a;
            Console.WriteLine(b);


            double c = 9.8;
            int d = (int)c;

            long e = 10;
            int f = (int)e;
            Console.WriteLine($"e is {e} and f is {f}");

            e = long.MaxValue;
            f = (int)e;

            Console.WriteLine($"e is {e} and f is {f}");
        }
    }

    class ClassFive
    {
        public static void ConvertToString()
        {
            Console.WriteLine("ClassFive - ConvertToString");
            int number = 12;

            Console.WriteLine(number.ToString());

            bool boolean = true;
            Console.WriteLine(boolean.ToString());


            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            object me = new object();
            Console.WriteLine(me.ToString());
        }
    }


    class ClassSix
    {
        public static void ParseToNumbersAndDates()
        {
            Console.WriteLine("ClassSix - ParseToNumbersAndDates");
            int age = int.Parse("27");

            DateTime birthday = DateTime.Parse("4 July 1980");

            Console.WriteLine($"I was born {age} years ago.");
            Console.WriteLine($"My birthday is {birthday}.");
            Console.WriteLine($"My birthday is {birthday:D}.");

        }
    }
}


