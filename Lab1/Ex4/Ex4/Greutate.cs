using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Greutate
    {
        public double kgFemei(double cm, int varsta)

        {
            return (cm-100- ((cm-150)/2.5) + ((varsta-20)/6));
        }

        public double kgBarbati(double cm, int varsta)

        {
            return (cm - 100 - ((cm - 150) / 4) + ((varsta - 20) / 4));
        }

        public void Afisare(double cm,double varsta,char op, double gideala)
        {
            Console.WriteLine("Cm:{0}  Varsta:{1}  Sex:{2} -> {3}", cm,varsta,op,gideala);
        }
    }
}
