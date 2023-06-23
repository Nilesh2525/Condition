using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    internal class Calculation1
        //Arithmatic operator//
    {
        static void Main(string[] args)
        {

            double r;
            double area;
            Console.WriteLine(  " Enter redius ");
            r = Convert.ToInt32(Console.ReadLine());

            area = 3.14 * r * r;
            Console.WriteLine(  area );

        }
    }
}
