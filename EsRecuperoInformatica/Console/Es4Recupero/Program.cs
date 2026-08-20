
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es4Recupero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] v;
            string temp;
            int dim = 50;
            v = new string[dim];
            Console.WriteLine("Quante parole vuoi inserire nel vettore?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Inserisci la parola nella posizione " + i + ":");
                v[i] = Convert.ToString(Console.ReadLine());
            }
            for (int i = 0; i < n / 2; i++)
            {
                temp = v[i];
                v[i] = v[n - 1 - i];
                v[n - 1 - i] = temp;
            }
            Console.WriteLine("Vettore invertito:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(v[i]);
            }
            Console.ReadKey();
        }
    }
}
