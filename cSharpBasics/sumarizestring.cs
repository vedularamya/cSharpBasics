using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics
{
    public static class SumarizeString
    { 
        static SumarizeString()
        {

        }
        public static void StringOps()
        {
            var inputText = "Hey Siri What Are You Doing And How Are You";
            const int maxLength = 20;
            if(inputText.Length <= maxLength)
                Console.WriteLine(inputText);
            else
            {
                Console.WriteLine(inputText.Substring(0, maxLength) + " ...");
            }
        }






    }
}
