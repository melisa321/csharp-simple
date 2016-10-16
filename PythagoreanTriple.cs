using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Check if entered numbers give Pythagorean Triples a2  + b2 = c2");
            Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            c = int.Parse(Console.ReadLine());
            

            if ((a*a + b*b) == c*c)
            {
                Console.Write(" Numbers ");
                Console.Write("a = " +  a);
                Console.Write("b = " + b);
                Console.Write("c = " + c);
                Console.Write(" give Pythagorean Triples");
            }
            else
            {
                Console.Write(" Numbers ");
                Console.Write("a = " + a + ", ");
                Console.Write("b = " + b + ", ");
                Console.Write("c = " + c);
                Console.Write(" not give Pythagorean Triples");
            }
            Console.ReadKey();
            
        }
    }
}
