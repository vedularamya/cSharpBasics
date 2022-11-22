
using System;
using System.Linq;

namespace cSharpBasics
{
    public static class RePractice
    {
        private const string V = "javascrpit";

        public static int Absolute()
        {
            Console.WriteLine("Enter the input numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the input numbers");
            int b = Convert.ToInt32(Console.ReadLine());

            {
                if (a > b)
                    return (a - b) * 2;
                return b - a;


            }
        }

        public static void IntSum(int x, int y)
        {

            Console.WriteLine((x == 20) || (y == 20) || (x + y) == 20);

        }

        public static void Small()
        {

            Console.WriteLine(" Enter the string");
            var k = Console.ReadLine();
            Console.WriteLine(k.ToLower());
        }


        public static void WordLen()
        {
            Console.WriteLine("enter the string");
            var s = Console.ReadLine();
            string[] words = s.Split(new string[] { " " }, StringSplitOptions.None);
            string word = " ";
            int ctr = 0;
            foreach (string k in words)
            {
                if (k.Length > ctr)
                {
                    word = k;
                    ctr = k.Length;
                }
                {
                    Console.WriteLine(word);
                }
            }
        }
        public static void SumOfInt()
        {
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            {
                while (n != 0) ;
            }
            sum = +n / 10;
            Console.WriteLine(sum);
        }

        public static void Amulti()
        {
            int[] fristarray = { 1, 2, 3, -4, 5 };
            int[] secondarray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("array1: [{0}]", string.Join(",", fristarray));
            Console.WriteLine("array2:[{0}]", string.Join(",", secondarray));
            for (int i = 0; i < fristarray.Length; i++)
                Console.Write(fristarray[i] * secondarray[i] + ",");
            Console.WriteLine("/n");
        }
        public static void TwoMulti()
        {
            Console.WriteLine("Enter the input ");
            var k = Convert.ToInt32(Console.ReadLine());
            if (k > 0)
                Console.WriteLine(k % 3 == 0 || k % 7 == 0);
        }
        public static void StartWord()
        {
            Console.WriteLine(" enter the input");
            var k = Console.ReadLine();
            Console.WriteLine((k.Length < 5 && k.Equals("Hello")) || (k.StartsWith("Hello") && k[5] == ' '));
        }
        public static void Compare()
        {
            Console.Write("enter the frist number(<100):");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the second number (>200):");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m < 100 && n > 200);
        }
        public static void Range()
        {
            Console.WriteLine("enter the frist number");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m >= -10 && m <= 10 || n >= -10 && n <= 10);
        }
        public static void Gitting()
        {
            string s = "php";
            var result = " ";
            if (s.Length >= 1 && s[0] == 'p')
                result += s[0];
            if (s.Length >= 2 && s[1] == 'h')
                result += s[1];
            Console.WriteLine(result);
        }
        public static void MaxMin()
        {
            Console.WriteLine("enter the input A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the input B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the input C");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("larget number of 3:" + Math.Max(a, Math.Max(B, C)));
            Console.WriteLine("lowest number of 3:" + Math.Min(a, Math.Min(B, C)));

        }
        public static void NearestOf20()
        {
            Console.WriteLine("enter the input x ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the input y ");
            int y = Convert.ToInt32(Console.ReadLine());
            int num = 20;
            var val1 = Math.Abs(x - num);
            var val2 = Math.Abs(y - num);
            Console.WriteLine(val1 == val2 ? 0 : (val1 > val2 ? x : y));


        }
        public static void CheckingChar()
        {
            Console.WriteLine(" input astring(that at least one'w' char ):");
            string s = Console.ReadLine();
            var count = s.Count(s => s == 'w');
            Console.WriteLine(count >= 1 && count <= 3);
        }
        public static void OddString()
        {
            Console.WriteLine("Input a string:");
            string s = Console.ReadLine();
            var result = "";
            for (int i = 0; i < s.Length; i++)
                if (i % 2 == 0) result += s[i];
            Console.WriteLine(result);

        }
        public static void NumCount()
        {
            Console.WriteLine("input a integer");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] nums = { 1, 1, 2, 2, 3, 4, 5, 6, 7, 7, 8, 8, 8, 9, 9, 9 };
            Console.WriteLine(nums.Count(n => n == x));
        }
        public static void FristAndLsat()
        {
            Console.WriteLine("enter the integer");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine((num[0] == x) || (num[num.Length - 1] == x));
        }
        public static void AddingInt()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("\narray:[{0 }]", string.Join(",", nums));
            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                Console.WriteLine("sum:" + sum);
            }
        }
        public static void CompareArrays()
        {
            int[] nums1 = { 1, 2, 3, 4, 5, 6, 7 };
            int nums1LastElementIndex = nums1.Length - 1;

            Console.WriteLine("\n array1:[{0}]", string.Join(",", nums1)); //array1:[1,2,3,4,5,6,7]


            int[] nums2 = { 1, 7, 6, 5, 4, 3, 2 };
            int nums2LastElementIndex = nums2.Length - 1;

            Console.WriteLine("\n array2:[{0}]", string.Join(",", nums2));

            Console.WriteLine("\n {0}", nums1[0].Equals(nums2[0])
                                ||
                               nums1[nums1LastElementIndex].Equals(nums2[nums2LastElementIndex])
                               );
        }

        public static void CheckOddNumbers()
        {
            int[] nums = { 2, 4, 8, 7, 6 };
            int[] oddArray = new int[nums.Length];
            int oddArrayIndex = 0;
            Console.WriteLine("\n originalarray[{0}]", string.Join(",", nums));
            foreach (var n in nums)
            {
                if (n % 2 != 0)
                {
                    oddArray[oddArrayIndex++] = n;
                    Console.WriteLine("contains odd number:");

                }
                Console.WriteLine("Does not contain any odd numbers");
            }

        }
        public static bool CheckPalindrome(string inputstring)




        {
            char[] C = inputstring.ToCharArray();
            Array.Reverse(C);
            return new string(C).Equals(inputstring);


        }

        public static void Arrange()
        {
            Console.WriteLine("ENTER the input");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", x);
            Console.WriteLine("{0}{0}{0}{0}", x);
            Console.WriteLine("{0} {0} {0} {0}", x);
            Console.WriteLine("{0}{0}{0}{0}", x);

        }
        public static void Rectangle()
        {
            Console.WriteLine("enter the input");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" {0}{0}{0}", y);
            Console.WriteLine(" {0}{0}", y);
            Console.WriteLine(" {0}{0}{0}", y);
            Console.WriteLine(" {0}{0}", y);
        }
        public static void HeatConvert()
        {
            Console.WriteLine("enter the input");
            int celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kelvin={0}", celsius + 273);
            Console.WriteLine("fahrenheit ={0}", celsius * 18 / 10 + 32);
        }
        public static string Remove_Char(string str, int n)
        {
            return str.Remove(n, 1);

        }
        public static string FirstLast(string ustr)
        {
            return ustr.Length > 1 ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
        public static void NewString()
        {
            string s;
            Console.WriteLine(" enter the input string:");
            s = Console.ReadLine();
            if (s.Length >= 1)
            {
                var k = s.Substring(0, 1);
                Console.WriteLine(k + s + k);
            }


        }
        public static void Result()
        {
            Console.WriteLine("Enter the first num:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second num:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((x > 0 && y < 0 || x < 0 && y > 0));
        }
        public static int SumTriple(int a, int b)
        {
            return a != b ? a + b : 3 * (a + b);
        }
        public static bool Result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true;
            return false;
        }

        public static void LowerCase(string s)
        {
            Console.WriteLine(s.ToLower());
        }

        public static void oddnums()
        {
            for (int n = 1; n < (99 + 1); n++)
            {
                if (n % 2 != 0)
                    Console.WriteLine(n);
            }
        }
        public static void DigitSum()
        {
            Console.WriteLine("enter the input");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (input > 0)
            {
                sum += input % 10;
                input = input / 10;
                Console.WriteLine(sum);

            }
            Console.WriteLine(sum);

        }
        public static void ReverseString()
        {
            string line = Console.ReadLine();
            var Words = line.Split(" ");
            Array.Reverse(Words);
            foreach (string s in Words)
            {
                Console.Write(s);
                Console.Write(' ');
            }
        }
        public static void StringTriple()
        {
            string line = Console.ReadLine();
            if (line.Length < 4)
            {
                Console.WriteLine(line);
            }
            else
            {
                string s = line.Substring(line.Length - 4, 4);
                Console.WriteLine(" {0}{0}{0}{0}", s);
            }
        }
        public static bool StrictlyIncreasingArray(int[] input)
        {
            foreach (var number in input)
            {
                int matchcount = 0;
                foreach (var number1 in input)
                {
                    if (number == number1)
                    {
                        matchcount++;
                        if (matchcount > 1) return false;
                    }
                }
            }
            return true;
        }
        public static int[] SortArray(int[] input)
        {
            var sortedarraywithoutnagativefive = input.Where(x => x != -5).OrderBy(X => X).ToArray();
            int sortednumbercount = 0;
            return input.Select(x => x >= 0 ? sortedarraywithoutnagativefive[sortednumbercount++] : -5).ToArray();
        }

        public static int test(string str1, char uc, char lc)
        {
            return str1.Split(uc, lc).Length - 1;
        }

        public static string Test(string word)
        {
            int length = word.Length;
            if (length % 2 == 0)
            {
                return "Even length";

            }
            else
            {
                return "odd length";
            }
        }
        public static int NthOddNumber(int n)
        {
            return n * 2 - 1;
        }

        public static bool plural(string word)
        {
            return word.EndsWith("s");
        }
        public static int SumOFSquare(int[] nums)
        {
            return nums.Sum(n => n * n);
        }

        public static double[] CumulativeSum(double[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i - 1];
            }
            return nums;
        }

        public static void PrintArray(double[] nums, string message)
        {
            Console.WriteLine(message);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.Write("\n");
        }

       public static string  GetTheNumberAndDigit(string text)
        {
            int   countLetters = text.Count(char.IsLetter);
            int countDigits = text.Count(char.IsDigit);
            return "number of letters: " + countLetters + "number of digits:" + countDigits; 
        }

public static bool ReverseTheBoolean(bool boolean)
        {
            return boolean;
        }

        public static string CountOfPosAndNeg(int[] nums)
        {
            var pos = nums.Where(n => n > 0).Count();
            var neg = nums.Where(n => n < 0).Count();
            return "\n number of pos numbers:" + pos + "\n number of neg numbers:" + neg;  

        }


    }
}















