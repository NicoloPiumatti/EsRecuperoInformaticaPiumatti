using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es10Recupero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v;
            int n, j, somma = 0;
            Console.WriteLine("Inserire la dimensione del vettore");
            n = Convert.ToInt32(Console.ReadLine());
            v = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Inserire n in pos " + i);
                v[i] = Convert.ToInt32(Console.ReadLine());
            }
            j = n - 1;
            for(int i = 0; i <= j; i++)
            {
                somma = somma + (v[i] * v[j]);
                j--;
            }
            Console.WriteLine(somma);
        }
    }
}
