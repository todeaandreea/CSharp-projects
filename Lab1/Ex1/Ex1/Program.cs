using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Introduceti nr de termeni care se vor afisa.");
            n=int.Parse(Console.ReadLine());

            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Fibonacci [{0}] este {1}", i, Fibonacci(i));
            }
            Console.ReadKey();
        }

        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else 
                return Fibonacci(n - 1)+Fibonacci(n - 2);
        }
    }
}
