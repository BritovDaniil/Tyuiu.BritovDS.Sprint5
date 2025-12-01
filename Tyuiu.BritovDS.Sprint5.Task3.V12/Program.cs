using Tyuiu.BritovDS.Sprint5.Task3.V12.Lib;

Console.Title = "Спринт #5 | Выполнил: Бритов Д. С. | ИСПб-25-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #5                                                            *");
Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                  *");
Console.WriteLine("* Задание #3                                                           *");
Console.WriteLine("* Вариант #12                                                          *");
Console.WriteLine("* Выполнил: Бритов Д. С. | ИСПб-25-1                                   *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить *");
Console.WriteLine("* в бинарный файл OutPutFileTask3.bin и вывести на консоль.            *");
Console.WriteLine("* Округлить до трёх знаков после запятой.                              *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

double result;
using (var br = new BinaryReader(File.Open(new DataService().SaveToFileTextData(3), FileMode.Open)))
{
    result = br.ReadDouble();
}
Console.WriteLine(result);
Console.ReadLine();