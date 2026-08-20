using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es6Recupero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int sPari = 0, sDispari = 0, max = 0, min = 1000, diff = 0;
            for(int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Inserire n in pos " + i);
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < vet.Length; i++)
            {
                if(i % 2 == 0)
                {
                    sPari = sPari + vet[i];
                } else
                    sDispari = sDispari + vet[i];
                if (vet[i] > max)
                    max = vet[i];
                if(vet[i] < min)
                    min = vet[i];
            }
            diff = max - min;
            Console.WriteLine("La somma degli indici pari è " + sPari + " , la somma degli indici dispari è " + sDispari + " e la differenza tra il max e il min (" + max + ", " + min + ") è di " + diff);
            Console.ReadKey();
        }
    }
}
