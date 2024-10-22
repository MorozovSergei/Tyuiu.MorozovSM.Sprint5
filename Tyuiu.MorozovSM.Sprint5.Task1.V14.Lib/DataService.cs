using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MorozovSM.Sprint5.Task1.V14.Lib
{
    public class DataService : ISprint5Task1V14
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo f = new FileInfo(path);
            if (f.Exists) File.Delete(path);
            double x;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0) x = 0;
                else x = Math.Round((Math.Sin(i) / (i + 1.7)) - Math.Cos(i) * 4 * i - 6,2);
                if (i != stopValue) { File.AppendAllText(path, Convert.ToString(x) + '\n'); }
                else { File.AppendAllText(path, Convert.ToString(x)); }
                
            }
            return path;
        }
    }
}
