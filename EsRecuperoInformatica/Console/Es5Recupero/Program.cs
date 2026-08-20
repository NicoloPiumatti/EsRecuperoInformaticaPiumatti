using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es5Recupero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string car;
            string[] parola;
            int lung, cont = 0;
            Console.WriteLine("Inserire la lunghezza della parola");
            lung = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserire il carattere da cercare nella parola");
            car = Convert.ToString(Console.ReadLine());
            parola = new string[lung];
            for (int i = 0; i < lung; i++)
            {
                Console.WriteLine("Inserisci carattere numero " + i);
                parola[i] = Convert.ToString(Console.ReadLine());
            }
            for(int i = 0; i < lung; i++)
            {
                if (parola[i].Contains(car))
                {
                    cont++;
                }
            }
            Console.WriteLine("Il carattere contenuto nella parola si presenta " + cont + " volte");
            Console.ReadKey();
        }
    }
}
