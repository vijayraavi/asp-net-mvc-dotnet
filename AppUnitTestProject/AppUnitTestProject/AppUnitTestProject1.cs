using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppUnitTestProject
{
    [TestClass]
    public class AppUnitTestProject1
    {
        [TestMethod]
        [Priority(1)]
        public void TestMethod1()
        {
            System.Console.WriteLine("Test Method 1 Passed");
            Assert.IsTrue(1 == 1);
        }

        //[TestMethod]
        //[TestCategory("MathTest")]
        //public void TestMethod2()
        //{
        //    System.Console.WriteLine("Test Method 2 Failed");
        //    Assert.IsTrue(1 == 2);
        //}
    }
}
