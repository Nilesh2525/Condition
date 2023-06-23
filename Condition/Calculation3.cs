using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Condition
{
    internal class Calculation3
    {
        static void Main(string[] args)
        {
            int a, b, c,d;
            Console.WriteLine(  "Enter First Value");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Value");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine(c);
            d = (180 - c);
            Console.WriteLine(d);


        }
    }
}
