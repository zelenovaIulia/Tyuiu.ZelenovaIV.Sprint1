using Tyuiu.ZelenovaIV.Sprint1.Task3.V10.Lib;

namespace Tyuiu.ZelenovaIV.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var x = 30.5;

            var res = ds.NumberToMoney(x);

            Assert.AreEqual("30.5 руб. - это 30 руб. 50 коп.", res);
        
        }
    }
}
