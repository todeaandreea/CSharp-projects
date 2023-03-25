using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Calcule
    {
        public double Adunare(double x, double y)
        {
            return x + y;
        }

        public double Scadere(double x, double y)
        {
            return x - y;
        }

        public double Inmultire(double x, double y)
        {
            return x * y;
        }

        public double Impartire(double x, double y)
        {
            if (y==0) return 0;
            else
            return x / y;
        }

        public void Afisare(double x, double y, char op, double rez)
        {
            Console.WriteLine("{0} {1} {2} = {3}", x, op, y, rez);
        }
    }
}
