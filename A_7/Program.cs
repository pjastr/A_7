using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 3 liczby, wprowadzenie każdej zakończ enterem.");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Średnia arytmetyczna: " + (a + b + c) / 3);
            Console.WriteLine("Średnia geometryczna: " + Math.Pow(a * b * c, 1.0 / 3));
            Console.ReadKey();
        }
    }
}
