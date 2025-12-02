using Tyuiu.BritovDS.Sprint5.Task6.V3.Lib;

namespace Tyuiu.BritovDS.Sprint5.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Бритов Д. С. | ИСПб-25-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #5                                                     *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                              *");
            Console.WriteLine("* Задание #6                                                    *");
            Console.WriteLine("* Вариант #3                                                    *");
            Console.WriteLine("* Выполнил : Бритов Д. С. | ИСПб-25-1                           *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дан набор символьных данных. Найти количество латинских букв  *");

            string path = @"C:\DataSprint5\InPutDataFileTask6V3.txt";

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* {ds.LoadFromDataFile(path)} ");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();

        }
    }
}