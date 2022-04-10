using Microsoft.VisualStudio.TestTools.UnitTesting;
using ce100_hw3_algo_lib_cs;
using System;

namespace ce100_hw3_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void longestCommonSubsquence_TestMethod1()
        {
            string s1 = "YUDKSGJSDFJLAIAROASDGAPAPPAFSKALSF";
            string s2 = "TPETIPWETDLGJSGJKHOEAFWIEFJSCBVBMN";


            int m = s1.Length;
            int n = s2.Length;
            string result = Class1.longestCommonSubsquence(s1, s2, m, n);
            string expected = "DGJSJOAFF";
            Assert.AreEqual(result, expected);
        }


        [TestMethod]
        public void longestCommonSubsquence_TestMethod2()
        {
            string s1 = "TWEIOWHFGHSAJFGASKWQAJSHF";
            string s2 = "AFVJHAFJWAUAABJXZ";


            int m = s1.Length;
            int n = s2.Length;
            string result = Class1.longestCommonSubsquence(s1, s2, m, n);
            string expected = "FHAFWAJ";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void longestCommonSubsquence_TestMethod3()
        {
            string s1 = "TASFHAJSF";
            string s2 = "ASKJFAKLFG";


            int m = s1.Length;
            int n = s2.Length;
            string result = Class1.longestCommonSubsquence(s1, s2, m, n);
            string expected = "ASFAF";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void matrixChainOrder_TestMethod1()
        {
            int[] arr = new int[] { 1, 2, 5, 7, 9 };
            int n = arr.Length;
            int res = Class1.matrixChainOrder(arr, 1, n - 1);
            Assert.AreEqual(res, 108);
        }

        [TestMethod]
        public void matrixChainOrder_TestMethod2()
        {
            int[] arr = new int[] { 4, 6, 8, 1, 7 };
            int n = arr.Length;
            int res = Class1.matrixChainOrder(arr, 1, n - 1);
            Assert.AreEqual(res, 100);
        }

        [TestMethod]
        public void matrixChainOrder_TestMethod3()
        {
            int[] arr = new int[] { 1, 5, 4, 7, 8 };
            int n = arr.Length;
            int res = Class1.matrixChainOrder(arr, 1, n - 1);
            Assert.AreEqual(res, 104);
        }
    }
}

