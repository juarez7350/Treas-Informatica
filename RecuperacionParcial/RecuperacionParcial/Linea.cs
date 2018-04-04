using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionParcial
{
        public interface ILinea<T>
        {
            double Longitud();
            T PuntoMasCercano(T punto);
        }    
}
