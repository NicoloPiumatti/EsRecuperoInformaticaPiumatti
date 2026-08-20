using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es7Recupero
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] v1, v2;
            int dim, n = 0;
            Console.WriteLine("Inserire la dimensione dell'array");
            dim = Convert.ToInt32(Console.ReadLine());
            v1 = new int[dim];
            v2 = new int[dim];
            for (int i = 0; i < dim; i++)
            {
                Console.WriteLine("Inserire in vet 1 di pos " + i + " n");
                v1[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserire in vet 2 di pos " + i + " n");
                v2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < dim; i++)
            {
                if (v1[i] == v2[i])
                {
                    n++;
                }
            }
            if(n == dim)
            {
                Console.WriteLine("I vettori v1 e v2 contengono in ogni singolo indice lo stesso valore");
            } else
                Console.WriteLine("I vettori v1 e v2 non contengono in ogni singolo indice lo stesso valore ma quelli uguali trovati sono " + n);
            Console.ReadKey();
        }
    }
}
