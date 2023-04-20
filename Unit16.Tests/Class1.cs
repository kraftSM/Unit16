using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Unit16;

namespace xc.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {
            Assert.True(100 == 100);
        }
        [Test]
        public void Test2()
        {
            Assert.False(50 == 100);
        }

    }
}
