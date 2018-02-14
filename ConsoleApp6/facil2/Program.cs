using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facil2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string palabra1, palabra2;
                Console.Write("Ingrese una palabra: ");
                palabra1 = Console.ReadLine();
                if (palabra1.Length == 0)
                    break;
                else
                {
                    Console.Write("Ingrese otra palabra: ");
                    palabra2 = Console.ReadLine();
                    if (anagramichi(palabra1, palabra2) == false)
                        Console.Write("No son anagramas.");
                    else
                        Console.Write("Son anagramas.");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }

        public static bool anagramichi(string P1, string P2)
        {
            int cont1, cont2;
            if (P1.Length == P2.Length)
            {
                for (int i = 0; i < P1.Length; i++)
                {
                    cont1 = 0;
                    cont2 = 0;
                    for (int j = 0; j < P2.Length; j++)
                    {
                        if (P1[i] == P2[j])
                            cont1++;
                        if (P1[i] == P2[j])
                            cont2++;
                    }
                    if (cont1 != cont2)
                        return false;
                }
                return true;
            }
            else
                return false;
        }

    }
}
