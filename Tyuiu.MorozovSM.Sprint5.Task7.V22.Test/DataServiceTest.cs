namespace Tyuiu.MorozovSM.Sprint5.Task7.V22.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V22.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool Exists = fileInfo.Exists;
            Assert.IsTrue(Exists);
        }
    }
}