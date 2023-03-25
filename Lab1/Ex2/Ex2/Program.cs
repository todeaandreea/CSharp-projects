using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a=0, b=0;
            char op;
            
            Calcule cal=new Calcule();

            Console.WriteLine("Introduceti 2 numere reale");
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b= double.Parse(Console.ReadLine());

            Console.Write("Introduceti operatia: ");
            op=char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+': cal.Afisare(a,b,op,cal.Adunare(a,b)); break;
                case '-': cal.Afisare(a, b, op, cal.Scadere(a, b)); break;
                case '*': cal.Afisare(a, b, op, cal.Inmultire(a, b)); break;
                case '/': cal.Afisare(a, b, op, cal.Impartire(a, b)); break;

            }

            Console.ReadKey();
        }
    }
}
