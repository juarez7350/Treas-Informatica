using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaBinTree
{
    class Class1
    {
        static void Main(string[] args)
        {
            IBinTree bTree = new BinaryTree(
                5,
                new BinaryTree(4),
                new BinaryTree(
                    9,
                    new BinaryTree(8),
                    null
                )
            );

            Console.WriteLine(bTree);
            Console.WriteLine(bTree.Sumar());
        }
    }
}
