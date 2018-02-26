using System;
using Xunit;
using Programs;

namespace GenericosTest
{
    public class GenericosTest
    {
        [Fact]
        public void HeadTest()
        {
            int[] arreglo = {1,2,3};
            Genericos gen = new Genericos();
            int value = gen.Head<int>(arreglo);
            Assert.AreEqual(value,arreglo[0]);
        }

        [Fact]
        public void TailTest(){
            int[] Arreglo1 = {10,20,30,40};
            Genericos gen = new Generico();
            int[] Arreglo2 = genericos.Tail<int>(Arreglo1);
            Assert.AreEqual(Arreglo1[0],Arreglo2[0]);
        }

        [Fact]
        public void TestZip(){
            Genericos gen = new Genericos();
            int[] a = { 1, 2, 3 , 4};
            int[] b = { 1, 2, 3 , 4};
            Tupla<int, int>[] array = gen.Zip<int, int>(a, b);

            for (int i = 0; i < arreglo.Length; i++)
            {
                Assert.AreEqual(a[i],array[i].primero);
                Assert.AreEqual(b[i],array[i].segundo);
            }
        }
    }
}
