using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            QueHacer QueHacer1 = new QueHacer(new DateTime(), "Casa", "Lavar Trastos");
            QueHacer QueHacer2 = new QueHacer(new DateTime(), "colonia", "Pasear mascota");
            QueHacer QueHacer3 = new QueHacer(new DateTime(), "centro comercial", "compra lentes");
            QueHacer QueHacer4 = new QueHacer(new DateTime(), "restaurante", "cenar");
            QueHacer QueHacer5 = new QueHacer(new DateTime(), "cuarto" , "hacer tareas");
            QueHacer QueHacer6 = new QueHacer(new DateTime(), "universidad", "estudiar");

            Persona Persona1 = new Persona();            
            Persona1.AgregarQueHacer(QueHacer1);
            Persona1.AgregarQueHacer(QueHacer3);
            Persona1.AgregarQueHacer(QueHacer4);

            Persona Persona2 = new Persona();
            Persona2.AgregarQueHacer(QueHacer2);
            Persona2.AgregarQueHacer(QueHacer5);
            Persona2.AgregarQueHacer(QueHacer6);

            Persona1.CompletarQueHacer();

            Persona2.CompletarQueHacer();
            Persona2.CompletarQueHacer();
            Persona2.CompletarQueHacer();

            Console.WriteLine("La persona uno esta disponible? {0}", Persona1.EstaDisponible());
            Console.WriteLine("La persona dos esta disponible? {0}", Persona2.EstaDisponible());

            Console.ReadLine();
        }
    }
}
