using Tyuiu.ZamyatinKP.Sprint1.Task6.V1.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Замятин К. П. | ПИНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Работа со строками класс String                                   *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Замятин Кирилл Павлович | ПИНб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая выводит код введенного пользователем символа*");
        Console.WriteLine("* Программа должна завершать работу в результате ввода, например, точки.  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите символ и нажмите <Enter>.");
        Console.WriteLine("Для завершения введите точку.");

        while (true)
        {
            Console.Write("-> ");
            string input = Console.ReadLine();
            if (input == ".")
            {
                break;
            }
            else
            {
                Console.WriteLine("Символ: " + input + " Код: " + ds.SymbolCode(input));
            }
        }

        Console.ReadLine();
    }
}