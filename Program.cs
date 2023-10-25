using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvodnaVjezba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;

            unosA: Console.Write("a: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("a < 0!!");
                goto unosA;
            }

            unosB: Console.Write("b: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b < 0)
            {
                Console.WriteLine("b < 0!!");
                goto unosB;
            }

            unosC: Console.Write("c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (c < 0)
            {
                Console.WriteLine("c < 0!!");
                goto unosC;
            }

            if (a * a + b * b == c * c)
            {
                Console.WriteLine("Trokut je pravokutan.");
            }
            if (a * a + b * b != c * c)
            {
                Console.WriteLine("Trokut nije pravokutan.");
            }

            Console.ReadKey();
        }
    }
}
