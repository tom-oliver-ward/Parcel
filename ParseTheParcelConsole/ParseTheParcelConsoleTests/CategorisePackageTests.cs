using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTheParcelConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTheParcelConsole.Tests
{
    [TestClass()]
    public class CategorisePackageTests
    {
        [TestMethod()]
        public void OptimisePackage_IncreasingLBHInput()
        {
            //arrange
            var userPackageOptimised = new UserPackage();
            var userPackage = new UserPackage();
            var categorisePackage = new CategorisePackage();

            userPackage.Length = 300;
            userPackage.Breadth = 400;
            userPackage.Height = 500;

            var expectedLength = 400;
            var expectedBreadth = 500;
            var expectedHeight = 300;

            //act
            categorisePackage.OptimiseUserPackageOrientation(userPackageOptimised, userPackage);

            //assert
            Assert.AreEqual(expectedLength, userPackageOptimised.Length);
            Assert.AreEqual(expectedBreadth, userPackageOptimised.Breadth);
            Assert.AreEqual(expectedHeight, userPackageOptimised.Height);
        }

        [TestMethod()]
        public void OptimisePackage_DecresingLBHInput()
        {
            //arrange
            var userPackageOptimised = new UserPackage();
            var userPackage = new UserPackage();
            var categorisePackage = new CategorisePackage();

            userPackage.Length = 500;
            userPackage.Breadth = 400;
            userPackage.Height = 300;

            var expectedLength = 400;
            var expectedBreadth = 500;
            var expectedHeight = 300;

            //act
            categorisePackage.OptimiseUserPackageOrientation(userPackageOptimised, userPackage);

            //assert
            Assert.AreEqual(expectedLength, userPackageOptimised.Length);
            Assert.AreEqual(expectedBreadth, userPackageOptimised.Breadth);
            Assert.AreEqual(expectedHeight, userPackageOptimised.Height);
        }

        [TestMethod()]
        public void OptimisePackage_PeakingLBHInput()
        {
            //arrange
            var userPackageOptimised = new UserPackage();
            var userPackage = new UserPackage();
            var categorisePackage = new CategorisePackage();

            userPackage.Length = 400;
            userPackage.Breadth = 500;
            userPackage.Height = 300;

            var expectedLength = 400;
            var expectedBreadth = 500;
            var expectedHeight = 300;

            //act
            categorisePackage.OptimiseUserPackageOrientation(userPackageOptimised, userPackage);

            //assert
            Assert.AreEqual(expectedLength, userPackageOptimised.Length);
            Assert.AreEqual(expectedBreadth, userPackageOptimised.Breadth);
            Assert.AreEqual(expectedHeight, userPackageOptimised.Height);
        }

        [TestMethod()]
        public void OptimisePackage_EqualInputs()
        {
            //arrange
            var userPackageOptimised = new UserPackage();
            var userPackage = new UserPackage();
            var categorisePackage = new CategorisePackage();

            userPackage.Length = 400;
            userPackage.Breadth = 400;
            userPackage.Height = 400;

            var expectedLength = 400;
            var expectedBreadth = 400;
            var expectedHeight = 400;

            //act
            categorisePackage.OptimiseUserPackageOrientation(userPackageOptimised, userPackage);

            //assert
            Assert.AreEqual(expectedLength, userPackageOptimised.Length);
            Assert.AreEqual(expectedBreadth, userPackageOptimised.Breadth);
            Assert.AreEqual(expectedHeight, userPackageOptimised.Height);
        }

        [TestMethod()]
        public void OptimisePackage_TwoEqualInputs()
        {
            //arrange
            var userPackageOptimised = new UserPackage();
            var userPackage = new UserPackage();
            var categorisePackage = new CategorisePackage();

            userPackage.Length = 400;
            userPackage.Breadth = 500;
            userPackage.Height = 400;

            var expectedLength = 400;
            var expectedBreadth = 500;
            var expectedHeight = 400;

            //act
            categorisePackage.OptimiseUserPackageOrientation(userPackageOptimised, userPackage);

            //assert
            Assert.AreEqual(expectedLength, userPackageOptimised.Length);
            Assert.AreEqual(expectedBreadth, userPackageOptimised.Breadth);
            Assert.AreEqual(expectedHeight, userPackageOptimised.Height);
        }

        [TestMethod()]
        public void TestLengthTest_SmallPackageInput()
        {
            //arrange
            var categorisePackage = new CategorisePackage();
            double costExpected = 5;
            int length = 200;

            //act
            double cost = categorisePackage.TestLength(length);

            //assert
            Assert.AreEqual(costExpected, cost);
        }

        [TestMethod()]
        public void TestLengthTest_MediumPackageInput()
        {
            //arrange
            var categorisePackage = new CategorisePackage();
            double costExpected = 7.5;
            int length = 300;

            //act
            double cost = categorisePackage.TestLength(length);

            //assert
            Assert.AreEqual(costExpected, cost);
        }

        [TestMethod()]
        public void TestLengthTest_LargePackageInput()
        {
            //arrange
            var categorisePackage = new CategorisePackage();
            double costExpected = 8.5;
            int length = 400;

            //act
            double cost = categorisePackage.TestLength(length);

            //assert
            Assert.AreEqual(costExpected, cost);
        }

        [TestMethod()]
        public void TestLengthTest_OverSizePackageInput()
        {
            //arrange
            var categorisePackage = new CategorisePackage();
            double costExpected = -1;
            int length = 500;

            //act
            double cost = categorisePackage.TestLength(length);

            //assert
            Assert.AreEqual(costExpected, cost);
        }

        [TestMethod()]
        public void TestBreadthTest_SmallPackageInput()
        {
            //arrange
            var categorisePackage = new CategorisePackage();
            double costExpected = 5;
            int breadth = 250;

            //act
            double cost = categorisePackage.TestBreadth(breadth);

            //assert
            Assert.AreEqual(costExpected, cost);
        }

        [TestMethod()]
        public void TestBreadthTest_MediumPackageInput()
        {
            //arrange
            var categorisePackage = new CategorisePackage();
            double costExpected = 7.5;
            int breadth = 350;

            //act
            double cost = categorisePackage.TestBreadth(breadth);

            //assert
            Assert.AreEqual(costExpected, cost);
        }

        [TestMethod()]
        public void TestBreadthTest_LargePackageInput()
        {
            //arrange
            var categorisePackage = new CategorisePackage();
            double costExpected = 8.5;
            int breadth = 500;

            //act
            double cost = categorisePackage.TestBreadth(breadth);

            //assert
            Assert.AreEqual(costExpected, cost);
        }

        [TestMethod()]
        public void TestBreadthTest_OversizePackageInput()
        {
            //arrange
            var categorisePackage = new CategorisePackage();
            double costExpected = -1;
            int breadth = 800;

            //act
            double cost = categorisePackage.TestBreadth(breadth);

            //assert
            Assert.AreEqual(costExpected, cost);
        }

        [TestMethod()]
        public void TestHeightTest_SmallPackageInput()
        {
            //arrange
            var categorisePackage = new CategorisePackage();
            double costExpected = 5;
            int height = 150;

            //act
            double cost = categorisePackage.TestHeight(height);

            //assert
            Assert.AreEqual(costExpected, cost);
        }

        [TestMethod()]
        public void TestHeightTest_MediumPackageInput()
        {
            //arrange
            var categorisePackage = new CategorisePackage();
            double costExpected = 7.5;
            int height = 200;

            //act
            double cost = categorisePackage.TestHeight(height);

            //assert
            Assert.AreEqual(costExpected, cost);
        }

        [TestMethod()]
        public void TestHeightTest_LargePackageInput()
        {
            //arrange
            var categorisePackage = new CategorisePackage();
            double costExpected = 8.5;
            int height = 250;

            //act
            double cost = categorisePackage.TestHeight(height);

            //assert
            Assert.AreEqual(costExpected, cost);
        }

        [TestMethod()]
        public void TestHeightTest_OverSizePackageInput()
        {
            //arrange
            var categorisePackage = new CategorisePackage();
            double costExpected = -1;
            int height = 300;

            //act
            double cost = categorisePackage.TestHeight(height);

            //assert
            Assert.AreEqual(costExpected, cost);
        }

        [TestMethod()]
        public void TestWeightTest_AllowedWeightPackageInput()
        {
            //arrange
            var categorisePackage = new CategorisePackage();
            double costExpected = 0;
            int weight = 20;

            //act
            double cost = categorisePackage.TestWeight(weight);

            //assert
            Assert.AreEqual(costExpected, cost);
        }

        [TestMethod()]
        public void TestWeightTest_OverSizePackageInput()
        {
            //arrange
            var categorisePackage = new CategorisePackage();
            double costExpected = -1;
            int weight = 30;

            //act
            double cost = categorisePackage.TestWeight(weight);

            //assert
            Assert.AreEqual(costExpected, cost);
        }

        
    }
}