using Tyuiu.ZelenovaIV.Sprint1.Task1.V16.Lib;

namespace Tyuiu.ZelenovaIV.Sprint1.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        
         DataService ds = new DataService();
         var x = 0;
            var e = 0;
            var t = 0;
         var res = ds.Calculate(x,e,t);
         Assert.AreEqual(0, res);
         
        }
    }
}
