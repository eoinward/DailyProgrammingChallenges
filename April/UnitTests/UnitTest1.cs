using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using 



namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConfrimThatItPasses()
        {
            List<int> list = new List<int>() { 10, 15, 3, 7 };
            int k = 17;

            bool retrunValue = function1. AdditionOfToNumbersInThisListEqualsK(list, k);
            Assert.AreEqual(retrunValue, true);
        }
    }
}
