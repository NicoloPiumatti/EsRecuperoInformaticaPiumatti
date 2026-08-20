using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es11Recupero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;
            int m, n, x = 1, max = 0, min = 100;
            Console.WriteLine("Inserire m");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserire n");
            n = Convert.ToInt32(Console.ReadLine());
            mat = new int[m, n];
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = x;
                    x++;
                    Console.Write(mat[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(mat[i, j] > max)
                        max = mat[i, j];
                    if(mat[i, j] < min)
                        min = mat[i, j];
                }
            }
            Console.WriteLine("Il numero minimo trovato è " + min + " mentre il max è " + max);
            Console.ReadKey();
        }
    }
}
