using Tyuiu.PopovAA.Sprint3.Task0.V9.Lib;
namespace Tyuiu.PopovAA.Sprint3.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            int start = 1;
            int finish = 15;
            var res = ds.GetSumSeries(x, start, finish);
            Assert.AreEqual(0.43, res);
        }
    }
}
