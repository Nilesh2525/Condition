using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Condition
{
    internal class Swichstatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  " 1 Addition ");
            Console.WriteLine(  " 2 substraction ");
            Console.WriteLine(  " 3 Multiplication ");
            Console.WriteLine(  " 4 Divission ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(  " Enter your first  number");
            
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter your second number");
            int n2 = Convert.ToInt32(Console.ReadLine());

            switch (option)// 1 or 2 or 3 or 4
            {
                case 1:
                    int sum = n1 + n2;
                    Console.WriteLine($"sum us {sum}");
                    break;
                case 2:
                    int sub = n1 - n2;
                    Console.WriteLine($"sub us {sub}");
                    break;
                case 3:
                    int mul = n1 * n2;
                    Console.WriteLine( $" mul us {mul}");
                    break;
                case 4:
                    int div = n1 / n2;
                    Console.WriteLine($" div us {div }");
                    break;

                default:
                
                    Console.WriteLine(" wrong option ");
                    break;



            }
        }
    }
}
