using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es9Recupero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] b10;
            string b2 = "";
            int n, resto = 0, numeroDecimale = 0;
            Console.WriteLine("Inserire lunghezza numero decimale");
            n = Convert.ToInt32(Console.ReadLine());
            b10 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Inserisci la cifra in posizione {i + 1}: ");
                b10[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                numeroDecimale = numeroDecimale * 10 + b10[i];
            }
            if (numeroDecimale == 0)
            {
                b2 = "0";
            }
            else
            {
                while (numeroDecimale > 0)
                {
                    resto = numeroDecimale % 2;
                    b2 = resto + b2; 
                    numeroDecimale = numeroDecimale / 2;
                }
            }
            Console.WriteLine($"Il numero binario corrispondente è: {b2}");
            Console.ReadKey();
        }
    }
}
