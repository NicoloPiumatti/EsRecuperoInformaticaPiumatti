using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es1Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min;
            int set, giorno, ore, minuti;
            Console.WriteLine("Inserire i minuti ");
            min = Convert.ToInt32(Console.ReadLine());
            set = min / 10080;
            giorno = min / 1440;
            ore = min / 60;
            Console.WriteLine("I minuti inseriti (" + min + ") corrispondo a: " + set + " settimane, " + giorno + " giorni, " + ore + " ore e " + min + " minuti");
            Console.ReadKey();
        }
    }
}
