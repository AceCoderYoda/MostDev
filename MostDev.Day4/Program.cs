#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.Day4.Program.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace MostDev.Day4
{
    public class Program
    {
        private static string AgeThing(int age)
        {
            if (age == 15 || age == 34) return "15";
            return "something else";

            return age == 15 || age == 34 ? "15" : "Something else";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var age = 15;
            string ageString;
            if (age == 15 || age == 34)
                ageString = "15";
            else
                ageString = "something else";

            var ageStr = age == 15 || age == 34 ? "15" : "Something else";


            Console.WriteLine(IterateNumbers(10));
            Console.WriteLine(IterateRecursively(10));

            Console.ReadKey();
        }

        private static int IterateNumbers(int numberOfTimes)
        {
            var sum = 0;
            for (var i = 0; i < numberOfTimes; i++) sum += i;

            return sum;
        }

        private static int IterateRecursively(int numberOfTimes)
        {
            if (numberOfTimes == 0) return 0;
            return IterateRecursively(numberOfTimes - 1) + numberOfTimes;

            // (10 - 1) + 10
            // (9 - 1) + 9
            // ... 
            // (0)
        }
    }
}