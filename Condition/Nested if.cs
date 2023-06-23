using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Condition
{
    internal class Nested_if
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter yuur first name");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter yuur second  name");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your third name");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2) ;
            {
                if (n1 > n3) ;
                Console.WriteLine(" greatest number is" +n1);
                 

            }
        }
        
        
        
        
        }
}
