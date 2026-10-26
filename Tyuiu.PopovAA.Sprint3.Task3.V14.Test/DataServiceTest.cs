using Tyuiu.PopovAA.Sprint3.Task3.V14.Lib;
namespace Tyuiu.PopovAA.Sprint3.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "fsdf sdfsdf sdfsdfsdd dddddd";
            char chr1 = 'd';
            char chr2 = 'e';
            string res = ds.ReplaceCharInString(str, chr1, chr2);
            Assert.AreEqual("fsef sefsef sefsefsee eeeeee", res);
        }
    }
}
