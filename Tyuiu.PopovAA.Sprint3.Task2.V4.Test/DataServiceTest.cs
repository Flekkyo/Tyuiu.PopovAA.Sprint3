using Tyuiu.PopovAA.Sprint3.Task2.V4.Lib;
namespace Tyuiu.PopovAA.Sprint3.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int s = 1;
            int f = 9;
            double res = ds.GetMultiplySeries(s, f);
            Assert.AreEqual(0.0212, res);
        }
    }
}
