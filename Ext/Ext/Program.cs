using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ext
{
    class Program
    {
        static void Main(string[] args)
        {
            string whatEver = "I am looking for all the letter a's";
            int howMany = whatEver.Looking();
            Console.WriteLine(howMany);

            int huh = 7;
            int anotherHuh = huh.Plus();
            Console.WriteLine(anotherHuh);

            double day = 12;
            double anotherDay = day.Money();
            Console.WriteLine(anotherDay);

            float sum = 7;
            float anotherSum = sum.Div();
            Console.WriteLine(anotherSum);

            Console.ReadKey();

        }
    }
}
