using ArithmeticOperations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace NUnitDemo
{
    [TestFixture]
    public class ArithmeticTestClass
    {
        public int a=10, b=20;

        [Test]
        public void TestSum()
        {
            Arithmetic ar = new Arithmetic();
            Assert.AreEqual(30, ar.Sum(a, b));
        }
    }
}
