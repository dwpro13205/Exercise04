using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication3;
namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestIsContain5()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5 };
            bool result1 = Program.IsContain5(Arr1);
            Assert.AreEqual(true, result1);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 6 };
            bool result2 = Program.IsContain5(Arr2);
            Assert.AreEqual(false, result2);

            int[] Arr3 = new int[0];
            bool result3 = Program.IsContain5(Arr3);
            Assert.AreEqual(false, result3);
        }
        [TestMethod]
        public void TestIsContain5or6()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4 };
            bool result1 = Program.IsContain5or6(Arr1);
            Assert.AreEqual(false, result1);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 5};
            bool result2 = Program.IsContain5or6(Arr2);
            Assert.AreEqual(true, result2);

            int[] Arr3 = new int[] { 1, 2, 3, 4,6 };
            bool result3 = Program.IsContain5or6(Arr3);
            Assert.AreEqual(true, result3);

            int[] Arr4 = new int[] { 1, 2, 3, 4, 6 , 5 };
            bool result4 = Program.IsContain5or6(Arr4);
            Assert.AreEqual(true, result4);

            int[] Arr5 = new int[0];
            bool result5 = Program.IsContain5or6(Arr5);
            Assert.AreEqual(false, result5);
        }
        [TestMethod]
        public void TestIsContain5and6()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4  };
            bool result1 = Program.IsContain5and6(Arr1);
            Assert.AreEqual(false, result1);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 5 };
            bool result2 = Program.IsContain5and6(Arr2);
            Assert.AreEqual(false, result2);

            int[] Arr3 = new int[] { 1, 2, 3, 4, 6 };
            bool result3 = Program.IsContain5and6(Arr3);
            Assert.AreEqual(false, result3);

            int[] Arr4 = new int[0];
            bool result4 = Program.IsContain5and6(Arr4);
            Assert.AreEqual(false, result4);

            int[] Arr5 = new int[] { 1, 2, 3, 4, 5, 6 };
            bool result5 = Program.IsContain5and6(Arr5);
            Assert.AreEqual(true, result5);
        }
         [TestMethod]
        public void TestCount5()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4 };
            int result1 = Program.Count5(Arr1);
            Assert.AreEqual(0, result1);

            int[] Arr2 = new int[] { 1, 2, 5 };
            int result2 = Program.Count5(Arr2);
            Assert.AreEqual(1, result2);

        }
        [TestMethod]
        public void TestCount5or6()
         {
             int[] Arr1 = new int[] { 1, 2, 3, 4 };
            int result1= Program.Count5or6(Arr1);
            Assert.AreEqual(0, result1);

            int[] Arr2 = new int[] { 1, 2, 3, 5 };
            int result2 = Program.Count5or6(Arr2);
            Assert.AreEqual(1, result2);

            int[] Arr3 = new int[] { 1, 3, 6, 6 };
            int result3 = Program.Count5or6(Arr3);
            Assert.AreEqual(2, result3);

            int[] Arr4 = new int[0];
            int result4 = Program.Count5or6(Arr4);
            Assert.AreEqual(0, result4);

            int[] Arr5 = new int[] { 1, 2, 3, 5, 6 };
            int result5 = Program.Count5or6(Arr5);
            Assert.AreEqual(2, result5);

            int[] Arr6 = new int[] { 1, 2, 5, 5 };
            int result6 = Program.Count5or6(Arr6);
            Assert.AreEqual(2, result6);

         }
        [TestMethod]
         public void TestSum()
         {   
            int []Arr2 = new int [0];
             int result2 = Program.Sum(Arr2);
             Assert.AreEqual(0,result2);

            int[] Arr1 = new int[] { 1, 2, 5, -5 };
            int result1 = Program.Sum(Arr1);
            Assert.AreEqual(3, result1);


         }
    }
}
