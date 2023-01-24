using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using XUnit;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalcEngineTest
    {
        private readonly CalcEngine _calcEngine = new CalcEngine();
        
        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int num1 = 1;
            int num2 = 2;

            double res = _calcEngine.Calculate("add", num1, num2);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int num1 = 1;
            int num2 = 2;

            double res = _calcEngine.Calculate("+", num1, num2);
            Assert.AreEqual(3, res);
        }
    }
}
