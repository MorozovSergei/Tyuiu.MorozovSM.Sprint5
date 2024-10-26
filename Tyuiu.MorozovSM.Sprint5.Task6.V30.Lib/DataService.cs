using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MorozovSM.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] nums = line.Split(" ");
                    foreach (string num in nums)
                    {
                        if (num.Length==8) count++;
                    }
                }
            }
            return count;
        }
    }
}
