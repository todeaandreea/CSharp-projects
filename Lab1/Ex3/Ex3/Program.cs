using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 0; char op;


            Console.WriteLine("Introduceti gradele");
            n = double.Parse(Console.ReadLine());


            Console.Write("Introduceti C sau F: ");
            op = char.Parse(Console.ReadLine());
            

            switch (op)
            {
                case 'C': Afisare(n,op,celsiusToF(n)) ; break;
                case 'F': Afisare(n, op,fahrenheitToC(n)); break;
            }

            Console.ReadKey();
        }

        static double celsiusToF(double C) {
            return C * 9 / 5 + 32;

        }

        static double fahrenheitToC(double F)
        {
            return ((F - 32) * 5 / 9);

        }

        static void Afisare(double n, char op, double rez)
        {
            Console.WriteLine("{0} {1} = {2}", n, op, rez);
        }


    }
}
