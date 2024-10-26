using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MorozovSM.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string str = "";
            using (StreamReader sr = new StreamReader(path)) 
            {
                string line;
                while ((line = sr.ReadLine()) != null) 
                {
                    line = line.Replace(".", "#");
                    line = line.Replace(",", "#");
                    line = line.Replace("!", "#");
                    line = line.Replace("?", "#");
                    line = line.Replace("-", "#");
                    str +=line;
                }
            }
            string NewPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V22.txt");
            FileInfo f = new FileInfo(NewPath);
            if (f.Exists) File.Delete(NewPath);
            File.AppendAllText(NewPath, str);
            return NewPath;
        }
    }
}
