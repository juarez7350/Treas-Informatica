namespace Genericos
{
    public class Genericos
    {
        public Genericos() { }
        
        public T Head<T>(T[] list)
        {
            return lisa[0];
        }
        
        public T[] cola<T>(T[] list)
        {
            T[] newLista = new T[list.Length - 1];
            int extra = 0;
            for (int i = 1; i < list.Length; i++)
            {
                newLista[extra] = list[i];
                extra += 1;
            }
            return newLista;
        }
        
        public Tupla<T1, T2>[] Zip<T1, T2>(T1[] lista1, T2[] lista2)
        {
            Tupla<T1, T2>[] arreglo = new Tupla<T1, T2>[Longitud<T1, T2>(lista1, lista2)];
            
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = new Tupla<T1, T2>(lista1[i], lista2[i]);
            }
            return arreglo;
        }
     
        private int Longitud<T1, T2>(T1[] valor1, T2[] valor2)
        {
            int longitud = 0;
            if (valor1.Length == valor2.Length)
            {
                longitud = valor1.Length;
            }
            else if (valor1.Length > valor2.Length)
            {
                longitud = valor2.Length;
            }
            else if (valor1.Length < valor2.Length)
            {
                longitud = valor1.Length;
            }
            return longitud;
        }
        
    }
}