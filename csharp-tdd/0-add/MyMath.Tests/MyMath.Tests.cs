using NUnit.Framework;
using MyMath;

namespace MyMath.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_Add_20_from_12_8()
        {
            Assert.AreEqual(22, Operations.Add(12, 10));
        }

        [TestCase(15, 10, 25)]
        [TestCase(-15, 10, -5)]
        [TestCase(15000, 10, 15010)]
        [TestCase(0, 0, 0)]
        public void Test_Operatins_Add(int a, int b, int res)
        {
            Assert.AreEqual(res, Operations.Add(a, b));
        }
    }
}