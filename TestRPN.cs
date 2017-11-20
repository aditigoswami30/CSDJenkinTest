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
            //Assert.AreEqual(9, objCal.sum(4, 5));
            Assert.AreEqual(10, objCal.sum(4, 5));
            //thota narayanarao added below code on 11/20/2017 at 11:10AM IST
            Assert.AreEqual(11, objCal.sum(5, 5));
        }
    }
}
