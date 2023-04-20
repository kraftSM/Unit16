using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NUnit.Framework;
using Unit16;

namespace Unit16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void CalculatorMustReturnNotNullableVal()
        {
            var calculatorTest = new Calculator();
            Assert.IsNotNull(calculatorTest);
        }
        
        public void AddAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Add(10, 220), Is.EqualTo(230));

        }
        

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(300, 10) == 290);
            Assert.That(calculator.Subtraction(300, 350) == -50);
            Assert.That(calculator.Subtraction(300, 300) == 0);
        }
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(300, 10) == 30);
            Assert.That(calculator.Division(300, 300) == 1);
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}
