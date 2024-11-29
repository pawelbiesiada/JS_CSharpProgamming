using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicCSharpConsoleNET.Exercises.Workshop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectNET
{
    [TestClass]
    public class PrimeNumberValidatorTests
    {
        [TestMethod]
        public void PrimeNumberValidator_CtorShouldNotFail_Test()
        {
            //assign, act
            PrimeNumberValidator prime = null;
            prime = new PrimeNumberValidator();

            
            // assert
            Assert.IsNotNull(prime);
        }

        [DataTestMethod]
        [DataRow(5)]
        [DataRow(7)]
        [DataRow(17)]
        public void PrimeNumberValidator_ReturnsTrue_WhenPrimeNumberProvided_Test(int primeNumber)
        {
            //assign
            PrimeNumberValidator prime = null;
            prime = new PrimeNumberValidator();

            //act
            var result = prime.IsPrimeNumber(primeNumber);

            // assert
            Assert.IsTrue(result);
        }


        [DataTestMethod]
        [DataRow(0)]
        [DataRow(8)]
        [DataRow(-3)]
        [DataRow(100)]
        public void PrimeNumberValidator_ReturnsFalse_WhenNotAPrimeNumberProvided_Test(int primeNumber)
        {
            //assign
            PrimeNumberValidator prime = null;
            prime = new PrimeNumberValidator();

            //act
            var result = prime.IsPrimeNumber(primeNumber);

            // assert
            Assert.IsFalse(result);
        }
    }
}
