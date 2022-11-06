using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("QuickUnitTest")]
namespace QuickDate
{
    internal class Calender
    {
        static void Main(string[] args)
        {
            DateTime now = GetCurrentDate();
            Console.WriteLine($"Today's date is {now}");
            Console.ReadLine();
        }
        internal static DateTime GetCurrentDate()
        {
            return DateTime.Now.Date;
        }
    }
}
