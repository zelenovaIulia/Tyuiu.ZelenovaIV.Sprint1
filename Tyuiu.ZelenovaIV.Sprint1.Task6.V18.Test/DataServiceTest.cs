﻿using Tyuiu.ZelenovaIV.Sprint1.Task6.V18.Lib;

namespace Tyuiu.ZelenovaIV.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string strTest = "1234";
            Assert.AreEqual(true, ds.CheckNumber(strTest));
        }
    }
}
