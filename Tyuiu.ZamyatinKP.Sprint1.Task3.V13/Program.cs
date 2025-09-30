using Tyuiu.ZamyatinKP.Sprint1.Task3.V13.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Замятин К. П. | ПИНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #13                                                              *");
        Console.WriteLine("* Выполнил: Замятин Кирилл Павлович | ПИНб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая позволяет найти произведение цифр           *");
        Console.WriteLine("* трехзначного числа. Ответ округлите до 3 знаков после запятой.          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x;

        Console.WriteLine("Введите трехзначное число:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.MultiplyOfDigits(x));

        Console.ReadLine();
    }
}