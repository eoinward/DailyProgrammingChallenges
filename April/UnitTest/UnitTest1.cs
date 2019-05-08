using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using DoesTheListAddUpToK;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsTrueList()
        {
            List<int> list = new List<int>() { 10, 15, 3, 7 };
            int k = 17;

            bool returnValue = Class1.AdditionOfToNumbersInThisListEqualsK(list, k);
            Assert.AreEqual(returnValue, true);

        }

        [TestMethod]
        public void TestIsFalseList()
        {
            List<int> list = new List<int>() { 10, 15, 3, 6 };
            int k = 17;

            bool returnValue = Class1.AdditionOfToNumbersInThisListEqualsK(list, k);
            Assert.AreEqual(returnValue, false);

        }

        [TestMethod]
        public void TestHasHalfTheValueInList()
        {
            List<int> list = new List<int>() { 10, 15, 2, 9 };
            int k = 18;

            bool returnValue = Class1.AdditionOfToNumbersInThisListEqualsK(list, k);
            Assert.AreEqual(returnValue, false);

        }

        [TestMethod]
        public void TestIsTrueArray()
        {
            int[] array = new int[] { 11, 14, 3, 7 };
            int k = 17;

            bool returnValue = Class1.AdditionOfToNumbersInThisListEqualsK(array, k);
            Assert.AreEqual(returnValue, true);

        }

        [TestMethod]
        public void TestIsFalseArray()
        {
            int[] array = new int[] { 10, 15, 3, 6 };
            int k = 17;

            bool returnValue = Class1.AdditionOfToNumbersInThisListEqualsK(array, k);
            Assert.AreEqual(returnValue, false);

        }

        [TestMethod]
        public void TestHasHalfTheValueInArray()
        {
            int[] array = new int[] { 10, 14, 3, 9 };
            int k = 18;

            bool returnValue = Class1.AdditionOfToNumbersInThisListEqualsK(array, k);
            Assert.AreEqual(returnValue, false);

        }



        [TestMethod]
        public void ArunIsTrueArray()
        {
            int[] array = new int[] { 11, 14, 3, 7 };
            int k = 17;

            bool returnValue = Class1.ArunSolution(array, k);
            Assert.AreEqual(returnValue, true);

        }

        [TestMethod]
        public void ArunIsFalseArray()
        {
            int[] array = new int[] { 10, 15, 3, 6 };
            int k = 17;

            bool returnValue = Class1.ArunSolution(array, k);
            Assert.AreEqual(returnValue, false);

        }

        [TestMethod]
        public void ArunHasHalfTheValueInArray()
        {
            int[] array = new int[] { 10, 14, 3, 9 };
            int k = 18;

            bool returnValue = Class1.ArunSolution(array, k);
            Assert.AreEqual(returnValue, false);

        }

        [TestMethod]
        public void NathanIsTrueArray()
        {
            int[] array = new int[] { 11, 14, 3, 7 };
            int k = 17;

            bool returnValue = Class1.NathanSolution(array, k);
            Assert.AreEqual(returnValue, true);

        }

        [TestMethod]
        public void NathanIsFalseArray()
        {
            int[] array = new int[] { 10, 15, 3, 6 };
            int k = 17;

            bool returnValue = Class1.NathanSolution(array, k);
            Assert.AreEqual(returnValue, false);

        }

        [TestMethod]
        public void NathanHasHalfTheValueInArray()
        {
            int[] array = new int[] { 10, 14, 3, 9 };
            int k = 18;

            bool returnValue = Class1.NathanSolution(array, k);
            Assert.AreEqual(returnValue, false);

        }

        [TestMethod]
        public void NathanMinus()
        {
            int[] array = new int[] { 10, -14, 3, 9 };
            int k = 18;

            bool returnValue = Class1.NathanSolution(array, k);
            Assert.AreEqual(returnValue, false);

        }

        [TestMethod]
        public void NathanIsTrueArray2()
        {
            int[] array = new int[] { 11, 14, 3, 7 };
            int k = 17;

            bool returnValue = Class1.GetTwoNumbersAddsUpToParam2(array, k);
            Assert.AreEqual(returnValue, true);

        }

        [TestMethod]
        public void NathanIsFalseArray2()
        {
            int[] array = new int[] { 10, 15, 3, 6 };
            int k = 17;

            bool returnValue = Class1.GetTwoNumbersAddsUpToParam2(array, k);
            Assert.AreEqual(returnValue, false);

        }

        [TestMethod]
        public void NathanHasHalfTheValueInArray2()
        {
            int[] array = new int[] { 10, 14, 3, 9 };
            int k = 18;

            bool returnValue = Class1.GetTwoNumbersAddsUpToParam2(array, k);
            Assert.AreEqual(returnValue, false);

        }

        [TestMethod]
        public void NathanMinus2()
        {
            int[] array = new int[] { 10, -14, 3, 9 };
            int k = 18;

            bool returnValue = Class1.GetTwoNumbersAddsUpToParam2(array, k);
            Assert.AreEqual(returnValue, false);

        }


        [TestMethod]
        public void FlagArraySolutionTrue()
        {
            int[] array = new int[] { 11, 14, 3, 7 };
            int k = 17;

            bool returnValue = Class1.FlagArraySolution(array, k);
            Assert.AreEqual(returnValue, true);

        }

        [TestMethod]
        public void FlagArraySolutionFalse()
        {
            int[] array = new int[] { 10, 15, 3, 6 };
            int k = 17;

            bool returnValue = Class1.FlagArraySolution(array, k);
            Assert.AreEqual(returnValue, false);

        }

        [TestMethod]
        public void FlagArraySolutionHalf()
        {
            int[] array = new int[] { 10, 14, 3, 9 };
            int k = 18;

            bool returnValue = Class1.FlagArraySolution(array, k);
            Assert.AreEqual(returnValue, false);

        }

        [TestMethod]
        public void FlagArraySolutionMinus()
        {
            int[] array = new int[] { 10, -14, 3, 9 };
            int k = 18;

            bool returnValue = Class1.FlagArraySolution(array, k);
            Assert.AreEqual(returnValue, false);

        }

    }
}
