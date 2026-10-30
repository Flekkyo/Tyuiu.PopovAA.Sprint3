using Tyuiu.PopovAA.Sprint3.Task7.V30.Lib;
namespace Tyuiu.PopovAA.Sprint3.Task7.V30.Test
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
            double[] res = ds.GetMassFunction(s, f);
            double[] exp = { -15.6, -12.35, -10.72, -8.88, -2.16, 3.25, 6.64, 10.3, 16.17, 28.1, 38.41 };
            CollectionAssert.AreEqual(exp, res);
        }
    }
}
