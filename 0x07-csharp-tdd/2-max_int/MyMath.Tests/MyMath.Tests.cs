using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void positiveNUmbers()
        {
            List<int> array = new List<int>();
            array.Add(5);
			array.Add(4);
			array.Add(8);
			array.Add(3);
			array.Add(1);

            int result = Operations.Max(array);

            Assert.AreEqual(8, result);
        }

        [Test]
        public void negativeNUmbers()
        {
            List<int> array = new List<int>();
            array.Add(-5);
			array.Add(-4);
			array.Add(-8);
			array.Add(-3);
			array.Add(-1);

            int result = Operations.Max(array);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void emptystring()
        {
            List<int> array = new List<int>();
            

            int result = Operations.Max(array);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void oneNUmbers()
        {
            List<int> array = new List<int>();
            array.Add(10);
			

            int result = Operations.Max(array);

            Assert.AreEqual(10, result);
        }

        [Test]
        public void repeatedNUmbers()
        {
            List<int> array = new List<int>();
            array.Add(10);
			array.Add(10);
            array.Add(10);
            array.Add(10);
            
            int result = Operations.Max(array);

            Assert.AreEqual(10, result);
        }
    }
}