using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSoftware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSoftware.Tests
{
    [TestClass()]
    public class MyRectangleTests
    {
        /* 單元測試     https://learn.microsoft.com/zh-tw/visualstudio/test/getting-started-with-unit-testing?view=vs-2022&tabs=dotnet%2Cmstest
         * 使用 Visual Studio 來定義和執行單元測試，藉以維護程式碼的健康狀態、確定程式碼涵蓋範圍，以及在客戶遭遇問題之前找出錯誤和失敗。 經常執行單元測試，以確定您的程式碼運作正常。
        */
        [TestMethod()]
        /*
        public void GetAreaTest()
        {
            Assert.Fail();
        }*/

        public void Given_W6_H8_Where_GetArea_Then_48()
        {
            var r = new MyRectangle() { width = 6 , height = 8 };
            double actual= r.GetArea();
            double expected = 48; //
            Assert.AreEqual(expected, actual);
        }

        [DataRow(12,5,60)]
        [DataRow(6,9,54)]
        //[DynamicData(nameof(GetData), DynamicDataSourceType.Method)]

        [DataTestMethod()]
        public void GetAreaDataTest(double width, double heigth, double expected)
        {
            var give =new MyRectangle { width= width, height= heigth};
            var actual= give.GetArea();
            Assert.AreEqual(expected, actual);
        }

        private static IEnumerable<object[]> GetData()
        {
            yield return new object[] { 6, 9, 54 };
            yield return new object[] { 12, 5, 60 };
            yield return new object[] { 17, 3, 51 };
        }


    }
}