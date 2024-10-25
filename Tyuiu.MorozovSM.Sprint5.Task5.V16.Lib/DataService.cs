using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MorozovSM.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            double max = double.MinValue;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    double num = Convert.ToDouble(line.Replace(".", ","));
                    if (num % 10 == 0 && num > max) max = num;
                }
            }
            return max;
        }
    }
}
