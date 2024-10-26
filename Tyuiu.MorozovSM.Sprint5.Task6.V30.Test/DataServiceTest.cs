using Tyuiu.MorozovSM.Sprint5.Task6.V30.Lib;

namespace Tyuiu.MorozovSM.Sprint5.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask6V30.txt";
        [TestMethod]
        public void CheckedExistsFile()
        {
            FileInfo fileInfo = new FileInfo(path);
            bool Exists = fileInfo.Exists;
            Assert.IsTrue(Exists);
        }
        [TestMethod]
        public void CalcValid()
        {
            var res = ds.LoadFromDataFile(path);
            Assert.AreEqual(1,res);
        }
    }
}