using System.IO;

namespace Tyuiu.MorozovSM.Sprint5.Task0.V22.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\necar\source\repos\Tyuiu.MorozovSM.Sprint5\Tyuiu.MorozovSM.Sprint5.Task0.V22\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool Exists = fileInfo.Exists;
            Assert.IsTrue(Exists);
        }
    }
}