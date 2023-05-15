using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugly_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.

            int n = 6;
            int n1 = 2;
            int n2 = 3;
            int n3 = 5;
            int temp = n1 * n2;
            int temp1 = n1 * n3;
            int temp2 = n3 * n1;
            int n4 = 14;


            if(n==temp)//6=2*3
            {
                Console.WriteLine(" Yes this is ugly number");
            }
            else
            {
                Console.WriteLine(" This is not ugly number");

            }
            //
            if((n4==temp)||(n4==temp1)|| (n4==temp2))//14=2*3,14=2*5,14=5*2
            {
                Console.WriteLine(" This second condition is ugly number");
            }
            else
            {
                Console.WriteLine(" This second condition is not ugly number");
            }
            Console.ReadLine();

        }
    }
}
