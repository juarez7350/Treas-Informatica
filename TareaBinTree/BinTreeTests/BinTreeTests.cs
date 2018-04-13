using System;
using Xunit;

namespace BinTreeTests
{
    public class BinTreeTests
    {
        [Fact]
        public void TestSuma()
        {
            IBinTree sut = new BinaryTree(
                7,
                new BinaryTree(6),
                new BinaryTree(
                    10,
                    new BinaryTree(2),
                    null
                )
            );

            Assert.Equal(25, sut.Sumar());
        }

        [Fact]
        public void TestInsert()
        {
            IBinTree sut = new BinaryTree(8);
            sut.Insert(15);
            sut.Insert(12);
            sut.Insert(27);
            sut.Insert(1);
            sut.Insert(16);
            sut.Insert(77);
            sut.Insert(29)
                ;
            int[] result = sut.ToArray();

            Assert.Equal(new int[] { 1, 12, 15, 16, 27, 29, 77  }, result);
        }
    }
}
