using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cSharpBasics
{
    public static class TeachingSession
    {
        /// <summary>
        /// This function verified whether the given array
        /// contains an strictly increasing sequence
        /// </summary>
        /// <param name="input"> This is the input array</param>
        /// <returns>True/False based on the array</returns>
        public static bool VerifyStrictlyIncreasingArray(int[] input)
        {
            foreach (var number in input)
            {
                int matchCount = 0;
                foreach (var number1 in input)
                {
                    if (number == number1)
                    {
                        matchCount++;
                        if (matchCount > 1) return false;
                    }
                }
            }

            return true;
            
        }

        public static int SumOfArrayOfArrays(int[][] input)
        { 
            var sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                { 
                    sum += input[i][j];
                    if ((input[i][j] == 0) && (i < input.Length - 1))
                    {
                        input[i + 1][j] = 0;
                    }
                }
            }
            return sum;
        }

        public static int[] SpecialSortArray(int[] input)
        {
            //I will remove the -5's & sort the remaining elements
            var sortedArrayExceptNegativeFive = input.Where(x => x != -5)
                                                     .OrderBy(x => x)
                                                     .ToArray();
            int sortedArrayIndex = 0;

            return input.Select(x => x >= 0 ?
                                        sortedArrayExceptNegativeFive[sortedArrayIndex++]
                                        : -5).ToArray();



        }

        internal static string RemoveBracesAndReverseString(string input)
        {

            int leftIndex = input.LastIndexOf("(");

            //If the index is negative, the string doesn't any paranthesis.
            //Hence return input as-is, no work required
            if (leftIndex < 0) return input;
            while (leftIndex > 0)
            {
                //Step1 - Find index of matching closing paranthesis
                int rightIndex = input.IndexOf(")", leftIndex);
               
                input = input.Substring(0,leftIndex) 
                    + new string(input.Substring(leftIndex + 1, rightIndex - leftIndex -1).Reverse().ToArray())
                    + input.Substring(rightIndex+1);
                
                
                leftIndex = input.LastIndexOf("(");
            }

            return input;
        }

        internal static string RemoveBracesAndReverseStringV2(string input)
        {

            int leftIndex = input.LastIndexOf("(");

            //If the index is negative, the string doesn't any paranthesis.
            //Hence return input as-is, no work required
            if (leftIndex < 0) return input;
            //Step1 - Find index of matching closing paranthesis
            int rightIndex = input.IndexOf(")", leftIndex);

            input = input.Substring(0, leftIndex)
                + new string(input.Substring(leftIndex + 1, rightIndex - leftIndex - 1).Reverse().ToArray())
                + input.Substring(rightIndex + 1);

            return RemoveBracesAndReverseStringV2(input);

        }

        internal static bool CheckIfExists(int[] givenArray, int input)
        {
            foreach (int number in givenArray)
            { 
                if (number == input) return true;
            }

            return false;

        }

    }
}
