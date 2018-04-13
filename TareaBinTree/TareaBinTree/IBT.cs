using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaBinTree
{
    public interface IBinTree
    {
        int Valor { get; }

        IBinTree Der { get; }

        IBinTree Izq{ get; }

        int Suma();

        int[] ToArray();

        void Insert(int value);
    }
}
