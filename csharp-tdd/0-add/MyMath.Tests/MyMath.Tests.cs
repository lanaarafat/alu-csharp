using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_Add()
        {
            Assert.IsEqual(8, Operations.Add(4,4));
        }

        [TestCase(0,0,0)]
        [TestCase(2,1,1)]
        [TestCase(6,3,3)]
        [TestCase(24,12,12)]
        public void Test_Operations_Add(int a, int b, int sum)
        {
            Assert.IsEqual(sum, Operations.Add(a, b));
        }
    }
}