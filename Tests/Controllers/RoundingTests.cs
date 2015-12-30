using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RideWizz;
using RideWizz.Controllers;
using RideWizz.Utilities;

namespace Tests.Controllers {
    [TestClass]
    public class RoundingTests {

        [TestMethod]
        public void NearestThousand0() {
            int input = 0;
            int expected = 0;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NearestThousand499() {
            int input = 499;
            int expected = 0;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NearestThousand500() {
            int input = 500;
            int expected = 1000;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NearestThousand501() {
            int input = 501;
            int expected = 1000;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NearestThousand999() {
            int input = 999;
            int expected = 1000;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NearestThousand1000() {
            int input = 1000;
            int expected = 1000;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NearestThousand1001() {
            int input = 1001;
            int expected = 1000;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void NearestThousand1499() {
            int input = 1499;
            int expected = 1000;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NearestThousand1500() {
            int input = 1500;
            int expected = 2000;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NearestThousand1501() {
            int input = 1501;
            int expected = 2000;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NearestThousand124265934() {
            int input = 124265934;
            int expected = 124266000;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NearestThousandMax() {
            int input = 2147483647;
            int expected = 2147483000;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NearestThousandNearMax() {
            int input = 2147483500;
            int expected = 2147483000;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NearestThousandNegative() {
            int input = -1;
            int expected = 0;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NearestThousandVeryNegative() {
            int input = -143679897;
            int expected = 0;
            int actual = VeryComplexMathEngine.RoundToNearestThousand(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
