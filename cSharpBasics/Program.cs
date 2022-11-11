﻿using System;
using System.Linq;

namespace cSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
           // TestingStrictlyIncreasing();
            //TestingSumOfArrayOfArrays();
            //TestingSpecialSortArray();

            //Console.WriteLine(TeachingSession.RemoveBracesAndReverseString(Console.ReadLine()));


            //TestingCheckIfExists();
            Console.WriteLine(TeachingSession.RemoveBracesAndReverseStringV2(Console.ReadLine()));
            
            Console.ReadLine();
        }
        internal static int[] MultiplyArrayWithItsLength(int[] nums)
        {
            return nums.Select(num => num * nums.Length).ToArray();
        }
        
        private static void TestingCheckIfExists()
        {
            int[] employeeArray = { 1, 50, 25, 90, 180 };
            Console.WriteLine("Enter an employee number");
            int employeeNumber = Convert.ToInt32(Console.ReadLine());

            while (employeeNumber != -1) ;
            {
                Console.WriteLine(TeachingSession.CheckIfExists(employeeArray, employeeNumber));
                Console.WriteLine("Enter an employee number");
                employeeNumber = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void TestingSpecialSortArray()
        {
            int[] input = new int[] { -5, 236, 120, 70, -5, -5, 698, 280 };
            var sortedArray = TeachingSession.SpecialSortArray(input);
            foreach (var item in sortedArray)
            {
                Console.WriteLine(item);
            }
        }

        static void TestingStrictlyIncreasing()
        {
            var input = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(TeachingSession.VerifyStrictlyIncreasingArray(input));
        }

        static void TestingSumOfArrayOfArrays()
        {
            int[][] input = {
                                new int[]{1,2,0,3 },
                                new int[]{4,0,6,7},
                                new int[]{0,1,2,3}
                            };

            Console.WriteLine(TeachingSession.SumOfArrayOfArrays(input));

        }

    


    }

}






