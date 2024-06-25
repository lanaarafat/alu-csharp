using NUnit.Framework;
using System.Collections.Generic;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Test_Max_01()
        {
            List<int> new_list = new List<int>(4);
            int res = Operations.Max(new_list);
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Test_Max_02()
        {
            List<int> new_list = null;
            int res = Operations.Max(new_list);
            Assert.AreEqual(0, res);
        }
        public void Test_Max_03()
        {
            List<int> new_list = new List<int>();
            new_list.Add(2);
            new_list.Add(8);
            new_list.Add(54);
            new_list.Add(14);
            int res = Operations.Max(new_list);
            Assert.AreEqual(54, res);
        }
        public void Test_Max_04()
        {
            List<int> new_list = new List<int>();
            new_list.Add(-2);
            new_list.Add(8);
            new_list.Add(-54);
            new_list.Add(14);
            int res = Operations.Max(new_list);
            Assert.AreEqual(14, res);
        }
        public void Test_Max_05()
        {
            List<int> new_list = new List<int>();
            new_list.Add(-2);
            new_list.Add(-8);
            new_list.Add(-54);
            new_list.Add(-14);
            int res = Operations.Max(new_list);
            Assert.AreEqual(-2, res);
        }
    }
}