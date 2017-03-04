using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// 打籃球有可能一球1分 2分 和 3分
        /// 假如總共1分的話 只有一種可能
        /// N分的話 有幾種可能
        /// 寫出一個函式 int ways(int n) {  ...  }
        /// </summary>

        [TestMethod]
        public void 一分一種方法()
        {
            // 1
            var target = new Calculater();
            int actual = target.Ways(1);
            var expected = 1;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void 二分二種方法()
        {
            // 1 + 1
            // 2

            var target = new Calculater();
            int actual = target.Ways(2);
            var expected = 2;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void 三分三種方法()
        {
            // 1 + 1 + 1
            // 1 + 2
            // 2 + 1
            // 3

            var target = new Calculater();
            int actual = target.Ways(3);
            var expected = 4;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void 四分七種方法()
        {
            // 1 + 1 + 1 + 1
            // 2 + 1 + 1
            // 1 + 2 + 1
            // 1 + 1 + 2
            // 3 + 1
            // 1 + 3
            // 2 + 2

            var target = new Calculater();
            int actual = target.Ways(4);
            var expected = 7;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void 五分十三種方法()
        {
            // 1 + 1 + 1 + 1 + 1
            // 2 + 1 + 1 + 1
            // 1 + 2 + 1 + 1
            // 1 + 1 + 2 + 1
            // 1 + 1 + 1 + 2
            // 3 + 1 + 1
            // 1 + 3 + 1
            // 1 + 1 + 3
            // 2 + 2 + 1
            // 2 + 1 + 2
            // 1 + 2 + 2
            // 3 + 2
            // 2 + 3

            var target = new Calculater();
            int actual = target.Ways(5);
            var expected = 13;

            Assert.AreEqual(expected, actual);

        }
    }
}
