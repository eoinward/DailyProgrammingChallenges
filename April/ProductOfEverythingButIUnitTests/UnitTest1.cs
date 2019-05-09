using DeepEqual.Syntax;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductOfEverythingButI;

namespace ProductOfEverythingButIUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProductOfEverythingButIBaseTest1()
        {
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expectedResult = { 120, 60, 40, 30, 24 };

            int[] actualResult = Class1.CalculateProductOfEverythingButI(input);
            // using https://github.com/jamesfoster/DeepEqual
            Assert.IsTrue(expectedResult.IsDeepEqual(actualResult));
        }

        [TestMethod]
        public void ProductOfEverythingButIBaseTest2()
        {
            int[] input = { 3, 2, 1 };
            int[] expectedResult = { 2, 3, 6 };

            int[] actualResult = Class1.CalculateProductOfEverythingButI(input);
            // using https://github.com/jamesfoster/DeepEqual
            Assert.IsTrue(expectedResult.IsDeepEqual(actualResult));
        }


        [TestMethod]
        public void ProductOfEverythingButIPrePostTest1()
        {
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expectedResult = { 120, 60, 40, 30, 24 };

            int[] actualResult = Class1.CalculateProductOfEverythingButIPreAnPost(input);
            // using https://github.com/jamesfoster/DeepEqual
            Assert.IsTrue(expectedResult.IsDeepEqual(actualResult));
        }

        [TestMethod]
        public void ProductOfEverythingButIPrePostTest2()
        {
            int[] input = { 3, 2, 1 };
            int[] expectedResult = { 2, 3, 6 };

            int[] actualResult = Class1.CalculateProductOfEverythingButIPreAnPost(input);
            // using https://github.com/jamesfoster/DeepEqual
            Assert.IsTrue(expectedResult.IsDeepEqual(actualResult));
        }
    }
}

