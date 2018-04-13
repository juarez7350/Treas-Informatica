using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaBinTree
{
    public class BinaryTree : IBinTree
    {
        public int Valor { get; }

        public IBinTree Der { get; set; }

        public IBinTree Izq { get; set; }

        public BinaryTree(int valor, IBinTree derecho, IBinTree izquierdo)
        {
            this.Valor = valor;
            this.Der = derecho;
            this.Izq = izquierdo;
        }

        public BinaryTree(int valor)
        {
            this.Valor = valor;
        }

        public override string ToString()
        {
            string derecho = this.Der == null ? string.Empty : this.Der.ToString();
            string izquierdo = this.Izq == null ? string.Empty : this.Izq.ToString();

            return $"{this.Valor} \n\t {derecho} \n\t {izquierdo}";
        }

        public int Suma()
        {
            int sumaIzq = this.Izq == null ? 0 : this.Izq.Suma();
            int sumaDer = this.Der == null ? 0 : this.Der.Suma();

            return sumaDer + sumaIzq + this.Valor;
        }

        public int[] ToArray()
        {
            var temp = new int[0];
            int[] total = new int[0];
            if (this.Izq != null)
            {
                var izqArr = Izq.ToArray();
                total = izqArr;
            }

            temp = new int[total.Length + 1];
            total.CopyTo(temp, 0);
            var valArr = new int[] { this.Valor };
            valArr.CopyTo(temp, total.Length);
            total = temp;

            if (this.Der != null)
            {
                var derArr = Der.ToArray();
                temp = new int[derArr.Length + total.Length];
                total.CopyTo(temp, 0);
                derArr.CopyTo(temp, total.Length);
            }

            total = temp;

            return total;
        }

        public void Insert(int valor)
        {
            if (valor <= this.Valor)
            {
                if (Izq == null)
                {
                    this.Izq = new BinaryTree(valor);
                }
                else
                {
                    Izq.Insert(valor);
                }
            }
            else
            {
                if (Der == null)
                    this.Der = new BinaryTree(valor);
                else
                    Der.Insert(valor);
            }
        }
    }
}
