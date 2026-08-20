using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es12Recupero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] m;
            int n, contDiag = 0, contResto = 0;
            bool isUnitaria = false;
            Console.WriteLine("Inserire righe e colonne della matrice");
            n = Convert.ToInt32(Console.ReadLine());
            m = new int[n, n];
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    m[i, j] = rnd.Next(0, 2);
                    Console.Write(m[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        if (m[i, j] != 0)
                        {
                            contDiag++;
                        }
                    } else
                    {
                        if (m[i, j] != 1)
                            contResto++;
                    }
                }
            }
            if(contDiag == n)
            {
                Console.WriteLine("Tutta la diagonale principale presenta 1");
            }
            if(contResto == (n * n) - contDiag)
            {
                Console.WriteLine("Tutto il resto della matrice quadrata contiene 0");
                isUnitaria = true;
            }
            if(isUnitaria)
            {
                Console.WriteLine("La matrice è unitaria!");
            }
            else
            {
                Console.WriteLine("La matrice non è unitaria!");
            }
                Console.ReadKey();
        }
    }
}
