using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es3Recupero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cifraBinaria, lungBinario;
            int decimale = 0;
            Console.Write("Quante cifre ha il numero binario? ");
            lungBinario = Convert.ToInt32(Console.ReadLine());
            for (int i = lungBinario - 1; i >= 0; i--)
            {
                Console.Write($"Inserisci la cifra binaria (mancano {i + 1} cifre): ");
                cifraBinaria = int.Parse(Console.ReadLine());
                if (cifraBinaria == 1)
                {
                    decimale = decimale + (int)Math.Pow(2, i);
                }
            }
            Console.WriteLine($"Il numero decimale corrispondente è: {decimale}");
            Console.ReadKey();
        }
    }
}
