using System.IO;

namespace Tyuiu.MorozovSM.Sprint5.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V16.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool Exists = fileInfo.Exists;
            Assert.IsTrue(Exists);
        }
    }
}