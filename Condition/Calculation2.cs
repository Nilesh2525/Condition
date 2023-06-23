using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    //rectangle and find the parameter//
    internal class Calculation2
    {
        static void Main(string[] args)
        {
            int l, b, a;
            Console.WriteLine(  "Enter lenght and breath");
            l = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            a = l * b ;
            Console.WriteLine(a);
        }
    }
}
