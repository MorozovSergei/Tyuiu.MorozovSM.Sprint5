using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MorozovSM.Sprint5.Task2.V22.Lib
{
    public class DataService : ISprint5Task2V22
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0);
            int columns = matrix.GetUpperBound(1);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo f = new FileInfo(path);
            if (f.Exists) {File.Delete(path);}
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= columns; j++)
                {
                    if (matrix[i, j] > 0) matrix[i, j] = 1;
                    else if(matrix[i, j] < 0) matrix[i, j] = 0;
                }
            }
            for (int i = 0; i <= rows; i++)
            {
                string str = "";
                for (int j = 0; j <= columns; j++)
                {
                    if (j < columns) str += Convert.ToString(matrix[i, j])+";";
                    else str += Convert.ToString(matrix[i, j]);
                }
                if (i < rows) File.AppendAllText(path,str+"\n");
                else File.AppendAllText(path, str);

            }
            return path;
        }
    }
}
