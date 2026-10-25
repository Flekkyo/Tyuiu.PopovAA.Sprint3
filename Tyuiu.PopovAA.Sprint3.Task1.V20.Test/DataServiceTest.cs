using Tyuiu.PopovAA.Sprint3.Task1.V20.Lib;
namespace Tyuiu.PopovAA.Sprint3.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 1;
            int finish = 16;
            double res = ds.GetSumSeries(start, finish);
            Assert.AreEqual(51191.4, res);
        }
    }
}
