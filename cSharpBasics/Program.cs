using System;

namespace cSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestingStrictlyIncreasing();
            //TestingSumOfArrayOfArrays();
            TestingSpecialSortArray();
            Console.ReadLine();
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






