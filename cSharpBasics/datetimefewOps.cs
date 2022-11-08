using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics
{
    public static class DatetimefewOps
    {
        public static void FewOps()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("f"));
            Console.WriteLine(DateTime.Now.ToString("s"));
            Console.WriteLine(DateTime.Now.AddDays(1));
            Console.WriteLine(DateTime.Now.AddHours(1));
            Console.WriteLine(DateTime.Now.AddDays(-1));
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
        public static void FewTsOps()
        {
            DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
            DateTime date2 = new DateTime(2010, 8, 18, 13, 30, 30);
            var interval = date2 - date1;
            Console.WriteLine("{0,-35}{1,20}{2,20}", "Value of Days Component KIran Kumar Vedula Sri Ramya Kakara:", interval.Days, "HI");
           var TimeSpan = new TimeSpan(2, 4, 6);
          var timespan1= new TimeSpan(3, 5, 7);
            var timespan2 = TimeSpan.Hours;
               

            var start =DateTime.Now;
            var end = DateTime.Now; 
            var duration = end - start;
            Console.WriteLine("duration" + duration);
        }









    }
}
