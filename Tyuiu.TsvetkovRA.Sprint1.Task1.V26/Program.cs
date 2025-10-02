using Tyuiu.TsvetkovRA.Sprint1.Task1.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
        Console.WriteLine("* и вычисляет результат по формуле и выводит результат на экран                                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x, y;
        Console.WriteLine("Введите значение х:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y:");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadLine();
    }
}