using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA
{
    class List
    {
        public abstract class Lista
        {
            bool Get(int indice);
            bool Set(int indice, T elemento);
            void Push(T elemento);
            int Lenght { get; }
        }
    }

    
}
