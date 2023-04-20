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

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(300, 10) == 290);
            Assert.That(calculator.Subtraction(300, -10) == 310);
            Assert.That(calculator.Subtraction(300, 350) == -50);
            Assert.That(calculator.Subtraction(300, 300) == 0);
        }
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(300, 10) == 30);
            Assert.That(calculator.Division(300, -10) == -30);
            Assert.That(calculator.Division(300, 300) == 1);
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(30, 10) == 300);
            Assert.That(calculator.Miltiplication(33, -10) == -330);
            Assert.That(calculator.Miltiplication(30, 0) == 0);
            Assert.That(calculator.Miltiplication(50, 1) == 50);
        }
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(30, 10) == 40);
            Assert.That(calculator.Additional(30, 0) == 30);
            Assert.That(calculator.Additional(50, -10) == 40);
        }
    }
}
