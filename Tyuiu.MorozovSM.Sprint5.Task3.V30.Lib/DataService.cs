using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MorozovSM.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double y = Math.Round((Math.Pow(x,3)-1)/(4*Math.Pow(x,2)), 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(Convert.ToString(y));
            }
            return path;
        }
    }
}
