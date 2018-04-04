using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionParcial
{
    public abstract class LineaAbstracta<T> : ILinea<T>
    {
        public abstract double Distancia(T p1, T p2);

        public abstract T[] Puntos { get; }

        public double Longitud()
        {
            if (Puntos.Length == 0)
                return 0;

            double longitud = 0;
            for (int i = 0; i < Puntos.Length - 1; i++)
            {
                longitud += Distancia(Puntos[i], Puntos[i + 1]);
            }
            return longitud;
        }

        public T PuntoMasCercano(T punto)
        {
            T total = Puntos[0];

            for (int i = 0; i < Puntos.Length; i++)
            {
                if (Distancia(punto, Puntos[i]) < Distancia(punto, total))
                   total = Puntos[i];
            }
            return total;
        }     
    }
}
