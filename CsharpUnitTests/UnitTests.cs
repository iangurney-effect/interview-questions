using InterviewQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CsharpUnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_Answer1()
        {
            int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] actual = Questions.Answer1(new int[] { 3, 4, 1, 5, 9, 2, 6, 0, 7, 8 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Answer2()
        {
            double[] expected = new double[] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };
            double[] actual = Questions.Answer2(new double[] { 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5 }, new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Answer3()
        {
            double expected = 5;
            double actual = Questions.Answer3(new double[] { 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5 }, new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            Assert.AreEqual(expected, actual);
        }
    }
}
