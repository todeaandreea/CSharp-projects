using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 0; int i;

            Console.WriteLine("Introduceti numarul de numere din vector");
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.Write("Introduceti elementele in vector :\n");

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Elementele vectorului sunt: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.WriteLine();
            Console.Write("Media geometrica a elementelor din vector este: ");
            Console.WriteLine(geometricMean(arr, n));

            Console.Write("Media aritmetica a elementelor din vector este: ");
            Console.WriteLine(arithmeticMean(arr,n));

            Console.ReadKey();

        }
        static float geometricMean(int[] arr, int n)
        {
            float p = 1;
            for (int i = 0;i < n;i++)
            {
                p = p * arr[i];
            }
            return (float)Math.Pow(p, (float)1 / n);
        }

        static float arithmeticMean(int[] arr, int n)
        {
            float s = 0;
            for (int i = 0; i < n; i++)
            {
                s= s+ arr[i];
            }
            return s/n;
        }

    }
}
