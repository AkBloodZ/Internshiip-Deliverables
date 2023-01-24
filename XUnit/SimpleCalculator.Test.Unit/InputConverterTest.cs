using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using XUnit;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();
        
        [TestMethod]
        public void ConvertsValidStringIntoDouble()
        {
            string inputNum = "5";
            double convertedNum = _inputConverter.ConvertInputToNumber(inputNum);

            Assert.AreEqual(5, convertedNum);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringIntoDouble()
        {
            string inputNum = "j";
            double convertedNum = _inputConverter.ConvertInputToNumber(inputNum);
        }
    }
}
