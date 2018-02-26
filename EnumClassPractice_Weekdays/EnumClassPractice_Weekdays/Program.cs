using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumClassPractice_Weekdays
{
    public enum Day
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    public class EnumTest
    {
        Day day;

        public EnumTest(Day day)
        {
            this.day = day;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
