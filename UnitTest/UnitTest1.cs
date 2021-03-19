using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckCoinNickelSuccess()
        {
            // Arrange
            int size = 5;
            int weight = 5;
            double expected = 0.05;
            
            
            // Assert
            double actual = BusinessLogic.CheckCoin(size, weight); 
            Assert.AreEqual(expected, actual, "Valid Coin");
        }
        [TestMethod]
        public void CheckCoinDimeSuccess()
        {
            // Arrange
            int size = 10;
            int weight = 10;
            double expected = 0.1;


            // Assert
            double actual = BusinessLogic.CheckCoin(size, weight);
            Assert.AreEqual(expected, actual, "Valid Coin");
        }
        [TestMethod]
        public void CheckCoinQuaterSuccess()
        {
            // Arrange
            int size = 25;
            int weight = 25;
            double expected = 0.25;


            // Assert
            double actual = BusinessLogic.CheckCoin(size, weight);
            Assert.AreEqual(expected, actual, "Valid Coin");
        }

        [TestMethod]
        public void CheckCoinFail()
        {
            // Arrange
            int size = 5;
            int weight = 5;
            double expected = 0.25;


            // Assert
            double actual = BusinessLogic.CheckCoin(size, weight);
            Assert.AreNotEqual(expected, actual, "InValid Coin");
        }

        [TestMethod]
        public void AcceptCoinSuccess()
        {

        }


        [TestMethod]
        public void SelectProductChipsSuccess()
        {
            // Arrange
            double amount = .5;
            string product = "Chips";
            bool expected = true;


            // Assert
            bool actual = BusinessLogic.SelectProduct(amount, product);
            Assert.AreEqual(expected, actual, "THANK YOU");
        }

        [TestMethod]
        public void SelectProductColaSuccess()
        {
            // Arrange
            double amount = 1;
            string product = "Cola";
            bool expected = true;


            // Assert
            bool actual = BusinessLogic.SelectProduct(amount, product);
            Assert.AreEqual(expected, actual, "THANK YOU");
        }

        [TestMethod]
        public void SelectProductCandySuccess()
        {
            // Arrange
            double amount = .65;
            string product = "Candy";
            bool expected = true;


            // Assert
            bool actual = BusinessLogic.SelectProduct(amount, product);
            Assert.AreEqual(expected, actual, "THANK YOU");
        }
        [TestMethod]
        public void SelectProductFail()
        {
            // Arrange
            double amount = .5;
            string product = "Cola";
            bool expected = true;


            // Assert
            bool actual = BusinessLogic.SelectProduct(amount, product);
            Assert.AreNotEqual(expected, actual, "INVALID PRODUCT");
        }

    }
}
