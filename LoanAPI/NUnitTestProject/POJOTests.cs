using NUnit.Framework;
using Loan.Data.Models;
using System;
using System.Threading;


namespace NUnitTestProject
{
    public class POJOTests
    {
        private LoanApplication loan;
        [SetUp]
        public void Setup()
        {
            loan = new LoanApplication();
        }

        [Test]
        public void LoanRateTest()
        {

            loan.Rate = 2.5;
            Thread.Sleep(10000);
            Assert.AreEqual(2.5, loan.Rate);

        }
        [Test]
        public void LoanTypeTest()
        {

            loan.Type = "mortgage";
            Thread.Sleep(10000);
            Assert.AreEqual("mortgage", loan.Type);
        }
        [Test]
        public void LoanDuration()
        {

            loan.RepaymentYears = 10;
            Thread.Sleep(10000);
            Assert.AreEqual(10, loan.RepaymentYears);
        }
    }
}
