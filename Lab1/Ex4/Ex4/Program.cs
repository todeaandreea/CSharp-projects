using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cm = 0; int varsta = 0;
            char s;

            Greutate g=new Greutate();
           
      

            Console.WriteLine("Introduceti inaltimea");
            Console.Write("cm = ");
            cm= double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti varsta");
            Console.Write("varsta = ");
            varsta = int.Parse(Console.ReadLine());


            Console.Write("Introduceti sexul(f/m): ");
            s = char.Parse(Console.ReadLine());

            switch (s)
            {
                case 'f': g.Afisare(cm,varsta,s,g.kgFemei(cm,varsta)); break;
                case 'm': g.Afisare(cm, varsta, s, g.kgBarbati(cm, varsta)); break;
            }

            Console.ReadKey();
        }
    }
}
