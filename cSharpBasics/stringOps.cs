using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics
{
    public static class StringOps
    {
        public static void SFewOps()
        {
            var fullName = "Sri Ramya ";
            Console.WriteLine("Trim :'{0}'", fullName.Trim());
            Console.WriteLine("Toupper: '{0}'", fullName.ToUpper());
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring( index + 1  );
            Console.WriteLine("FirstName: "  + firstName);
            Console.WriteLine("LastName: " + lastName);
            var names = fullName.Split(' ');
            Console.WriteLine("FristName:" + names[0]);
            Console.WriteLine("LastName: " + names[1]);

        } 

    }
}
