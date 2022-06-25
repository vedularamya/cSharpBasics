using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics
{
    public static class Arrays
    {
        static int[] employeeAge;
        static Arrays()
        {
            employeeAge = new int[100];

        }
        public static void AddElementstoArray()
        {
            Random randomAge = new Random();
            for (int i = 0; i < 100; i++)
            {
                employeeAge[i] = randomAge.Next(30,70);
            }
        }
        public static void IterateArray()
        {
            int i = 1;
            foreach (var item in employeeAge)
            {
                Console.WriteLine("Employ{0} age is {1}", i, item);
                i++;
            }
        }
    }
}
