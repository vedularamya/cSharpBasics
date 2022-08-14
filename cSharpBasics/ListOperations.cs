using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics
{
    public static class ListOperations
    {
        static List<int> numberList;
        static ListOperations()
        {
            numberList = new List<int>() { 10, 1, 15, 9 };
        }
        public static void AddToList()
        {
            numberList.Add(1);

            numberList.AddRange(new int[] { 20,25,1,75});

            numberList.AddRange(numberList);
        }

        public static void PrintList()
        {
            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }
        }

        public static void FewOps()
        {
            Console.WriteLine("Total numbers are {0} and index of element 10 is {1} & last index of 10 {2}",numberList.Count,numberList.IndexOf(10),numberList.LastIndexOf(10));
        }

        public static void RemoveElements()
        {
            Console.WriteLine("I am removing 4 elements starting at index 5 using RemoveRange");
            numberList.RemoveRange(5,4);

            numberList.RemoveAt(5);

            numberList.RemoveAll(x => x == 1);

            numberList.Remove(15);


        }

    }
}
