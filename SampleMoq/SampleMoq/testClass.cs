using ArithmeticOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SampleMoq
{

    [TestClass]
    public class TestClass
    {
        int a = 29, b = 22;

        [TestMethod]
        public void TestSum()
        {
            Arithmetic ar = new Arithmetic();
            Assert.AreEqual(51, ar.Sum(a,b));
        }
    }
}
