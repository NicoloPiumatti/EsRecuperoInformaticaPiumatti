using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es8Recupero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] alfabeto = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] succCar;
            int n;
            bool inOrdine = true;
            Console.WriteLine("Quanti caratteri vuoi inserire?");
            n = Convert.ToInt32(Console.ReadLine());
            succCar = new string[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Inserire carattere n " + i);
                succCar[i] = Convert.ToString(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                int indiceAttuale = Array.IndexOf(alfabeto, succCar[i]);
                int indiceSuccessivo = Array.IndexOf(alfabeto, succCar[i + 1]);
                if (indiceAttuale == -1 || indiceSuccessivo == -1)
                {
                    Console.WriteLine($"Errore: Uno dei caratteri ('{succCar[i]}' o '{succCar[i + 1]}') non è valido.");
                    inOrdine = false;
                    break;
                }
                if (indiceAttuale >= indiceSuccessivo)
                {
                    inOrdine = false;
                    break;
                }
            }
            if (inOrdine)
            {
                Console.WriteLine("I caratteri sono in ordine rispetto all'alfabeto fornito.");
            }
            else
            {
                Console.WriteLine("I caratteri NON sono in ordine rispetto all'alfabeto fornito.");
            }
        }
    }
}
