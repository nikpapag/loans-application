using NUnit.Framework;
using System;
using Loan.Data.Models;
using System.Threading;
using LoanAPI.Controllers;
using Loan.Data.Interfaces;
using Moq;


namespace NUnitTestProject
{
    public class MVCControllerTests
    {
        [Test]
        public void LoanReturnsCorrectIdTest()
        {
            var mockLoanRepo = new Mock<ILoanRepository>();

            var LoanId = 2;

            mockLoanRepo.Setup(x => x.GetLoan(It.IsAny<int>())).Returns(new LoanApplication() { Id = 2, Type = "mortgage", Amount = 100000, isVariable = true, Rate = 2.5, RepaymentYears = 25 });
            var controller = new LoansController(mockLoanRepo.Object);

            var response = controller.GetLoan(LoanId);


            Assert.AreEqual(LoanId, response.Value.Id);


        }

        [Test]
        public void LoanReturnsCorrectTypeTest()
        {
            var mockLoanRepo = new Mock<ILoanRepository>();
            var LoanId = 2;
            var type = "mortgage";

            mockLoanRepo.Setup(x => x.GetLoan(It.IsAny<int>())).Returns(new LoanApplication() { Id = 2, Type = "mortgage", Amount = 100000, isVariable = true, Rate = 2.5, RepaymentYears = 25 });
            var controller = new LoansController(mockLoanRepo.Object);

            var response = controller.GetLoan(LoanId);


            Assert.AreEqual(type, response.Value.Type);


        }
        [Test]
        public void LoanReturnsCorrectAmountTest()
        {
            var mockLoanRepo = new Mock<ILoanRepository>();
            var LoanId = 2;
            var amount = 100000;

            mockLoanRepo.Setup(x => x.GetLoan(It.IsAny<int>())).Returns(new LoanApplication() { Id = 2, Type = "mortgage", Amount = 100000, isVariable = true, Rate = 2.5, RepaymentYears = 25 });
            var controller = new LoansController(mockLoanRepo.Object);

            var response = controller.GetLoan(LoanId);


            Assert.AreEqual(amount, response.Value.Amount);


        }



        [Test]
        public void LoanReturnsCorrectVariableTest()
        {
            var mockLoanRepo = new Mock<ILoanRepository>();
            var LoanId = 2;
            var isVariable = true;

            mockLoanRepo.Setup(x => x.GetLoan(It.IsAny<int>())).Returns(new LoanApplication() { Id = 2, Type = "mortgage", Amount = 100000, isVariable = true, Rate = 2.5, RepaymentYears = 25 });
            var controller = new LoansController(mockLoanRepo.Object);

            var response = controller.GetLoan(LoanId);


            Assert.AreEqual(isVariable, response.Value.isVariable);


        }





        [Test]
        public void LoanReturnsCorrectRepaymentYearsTest()
        {
            var mockLoanRepo = new Mock<ILoanRepository>();
            var LoanId = 2;
            var RepaymentYears = 25;

            mockLoanRepo.Setup(x => x.GetLoan(It.IsAny<int>())).Returns(new LoanApplication() { Id = 2, Type = "mortgage", Amount = 100000, isVariable = true, Rate = 2.5, RepaymentYears = 25 });
            var controller = new LoansController(mockLoanRepo.Object);

            var response = controller.GetLoan(LoanId);


            Assert.AreEqual(RepaymentYears, response.Value.RepaymentYears);


        }



        [Test]
        public void LoanReturnsCorrectRatesTest()
        {
            var mockLoanRepo = new Mock<ILoanRepository>();
            var LoanId = 2;
            var Rate = 2.5;

            mockLoanRepo.Setup(x => x.GetLoan(It.IsAny<int>())).Returns(new LoanApplication() { Id = 2, Type = "mortgage", Amount = 100000, isVariable = true, Rate = 2.5, RepaymentYears = 25 });
            var controller = new LoansController(mockLoanRepo.Object);

            var response = controller.GetLoan(LoanId);


            Assert.AreEqual(Rate, response.Value.Rate);


        }
    }
}
