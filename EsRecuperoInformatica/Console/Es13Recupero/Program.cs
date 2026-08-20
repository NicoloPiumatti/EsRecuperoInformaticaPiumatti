using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es13Recupero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] m;
            int n, contSimm = 0;
            Console.WriteLine("Inserire le righe e le colonne della matrice");
            n = Convert.ToInt32(Console.ReadLine());
            m = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Inserire x in pos[" + i + ", " + j + "]");
                    m[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(m[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i != j && m[i, j] == m[j, i])
                        contSimm++;
                }
            }
            if(contSimm == (n * n) - n)
            {
                Console.WriteLine("La matrice è simmetrica");
            } else
            {
                Console.WriteLine("La matrice non è simmetrica");
            }
            Console.ReadKey();
        }
    }
}
