using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Tests</summary>
    public class OperationsTests
    {
        [Test]
        public void positiveInt()
        {
            int result = Operations.Add(2, 4);

            Assert.AreEqual(6, result);
        }

        [Test]
        public void negativeInt()
        {
            int result = Operations.Add(2, -10);

            Assert.AreEqual(-8, result);
        }
        
        [Test]
        public void bothNegativeInt()
        {
            int result = Operations.Add(-2, -10);

            Assert.AreEqual(-12, result);
        }

        [Test]
        public void CeroInt()
        {
            int result = Operations.Add(0, -10);

            Assert.AreEqual(-10, result);
        }

         [Test]
        
        public void BothCeroInt()
        {
            int result = Operations.Add(0, 0);

            Assert.AreEqual(0, result);
        }
    }
}