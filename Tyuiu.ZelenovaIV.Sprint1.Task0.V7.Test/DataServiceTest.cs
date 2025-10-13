using Tyuiu.ZelenovaIV.Sprint1.Task0.V7.Lib;

namespace Tyuiu.ZelenovaIV.Sprint1.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VaidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(5, res);
        }
    }
}
