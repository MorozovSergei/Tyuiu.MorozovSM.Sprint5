using Tyuiu.MorozovSM.Sprint5.Task5.V16.Lib;

namespace Tyuiu.MorozovSM.Sprint5.Task5.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Морозов С. М. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Морозов Сергей Максимович | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл) в    *");
            Console.WriteLine("* котором есть набор значений.Найти максимальное целое число в файле,     *");
            Console.WriteLine("* котороеделится на 10. Полученный результат вывести на консоль. У        *");
            Console.WriteLine("* вещественных значений округлить до трёх знаков после запятой.           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V16.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.LoadFromDataFile(path);
            Console.WriteLine("Максимальное число делящееся на 10 = "+res);
            Console.ReadKey();
        }
    }
}
