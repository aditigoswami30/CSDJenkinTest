using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RPNCalculator
{
    [TestFixture]
    class TestRPN
    {
        [Test]
        public void sumtest()
        {
        Calculate objCal = new Calculate();
            Assert.AreEqual(9, objCal.sum(4, 5));
        }
    }
}
