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
    public class UserInputTests
    {

        [TestMethod()]
        public void ValidInputTest_ExpectedInput()
        {
            //arrange
            var clientInterface = new UserInput();
            var clientPackage = new UserPackage();
            var input = "125.5";
            var expectedOutput = 125.5;

            //act
            var output = clientInterface.ValidInput(input);

            //assert
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod()]
        public void ValidInputTest_ZeroInput()
        {
            //arrange
            var clientInterface = new UserInput();
            var clientPackage = new UserPackage();
            var input = "0";
            var expectedOutput = 0;

            //act
            var output = clientInterface.ValidInput(input);

            //assert
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod()]
        public void ValidInputTest_BlankInput()
        {
            //arrange
            var clientInterface = new UserInput();
            var clientPackage = new UserPackage();
            var input = "";
            var expectedOutput = 0;

            //act
            var output = clientInterface.ValidInput(input);

            //assert
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod()]
        public void ValidInputTest_NonNumberInput()
        {
            //arrange
            var clientInterface = new UserInput();
            var clientPackage = new UserPackage();
            var input = "word";
            var expectedOutput = 0;

            //act
            var output = clientInterface.ValidInput(input);

            //assert
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod()]
        public void ValidInputTest_LargeInput()
        {
            //arrange
            var clientInterface = new UserInput();
            var clientPackage = new UserPackage();
            var input = "99999999999";
            var expectedOutput = 99999999999;

            //act
            var output = clientInterface.ValidInput(input);

            //assert
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod()]
        public void ValidInputTest_NegativeInput()
        {
            //arrange
            var clientInterface = new UserInput();
            var clientPackage = new UserPackage();
            var input = "-5";
            var expectedOutput = 0;

            //act
            var output = clientInterface.ValidInput(input);

            //assert
            Assert.AreEqual(expectedOutput, output);
        }
    }
}