using Tyuiu.PopovAA.Sprint3.Task4.V29.Lib;
namespace Tyuiu.PopovAA.Sprint3.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int s = -5;
            int f = 5;
            double res = ds.Calculate(s, f);
            Assert.AreEqual(0.104, res);
        }
    }
}
