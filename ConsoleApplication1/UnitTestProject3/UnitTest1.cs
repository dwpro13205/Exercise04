using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestFactorial()
        {
            long result1 = Program.Factorial( long int ( 3));
            Assert.AreEqual(6, result1);


            int result2 = Program.Factorial(2);
            Assert.AreEqual(2, result2);
        }
    }
}
