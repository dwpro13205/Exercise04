using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCeil()
        {
            int result1 = Program.Ceil((float)2.3);
            Assert.AreEqual(3,result1);

            
            int result2 = Program.Ceil(-2.3f);
            Assert.AreEqual(-2,result2);
        }
    }
}
