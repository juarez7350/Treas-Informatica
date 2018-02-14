using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facil1
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1 = "";
            string palabra2 = "";

            Console.WriteLine("Escriba la palabra que desea invertir: ");
            palabra1 = Console.ReadLine();

            for (int i = palabra1.Length - 1; i >= 0; i--)
            {
                palabra2 += palabra1[i];
            }
            Console.WriteLine("El resultado es: " + palabra2);
            Console.ReadKey();
        }
    }
}
