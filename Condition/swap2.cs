using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    internal class swap2
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Console.WriteLine(  "before swap");
            Console.WriteLine(  "a  " +a);
            Console.WriteLine(  "b" +b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swap");
            Console.WriteLine("a  " + a);
            Console.WriteLine("b" + b);


        }
    }
}
