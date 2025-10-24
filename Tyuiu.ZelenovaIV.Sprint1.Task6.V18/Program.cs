using Tyuiu.ZelenovaIV.Sprint1.Task6.V18.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string value;


        Console.Title = "Спринт #1 | Выполнил: Зеленова Ю. В. | АСОиУб-25-1";
        Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
        Console.WriteLine("* Спринт #1" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
        Console.WriteLine("* Тема: Работа со строками класс String" + String.Concat(Enumerable.Repeat(" ", 35)) + "*");
        Console.WriteLine("* Задание #6" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
        Console.WriteLine("* Вариант #18" + String.Concat(Enumerable.Repeat(" ", 61)) + "*");
        Console.WriteLine("* Выполнил: Зеленова Юлия Владимировна | АСОиУб-25-1" + String.Concat(Enumerable.Repeat(" ", 26)) + "*");
        Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
        Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
        Console.WriteLine("* Написать програму, которая запрашивает у пользователя исходные данные,  *");
        Console.WriteLine("* проверяет строку на символьный тип натурального числа                   *");
        Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
        Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
        Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));


        Console.WriteLine("Введите строку");
        value = Console.ReadLine();

        Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
        Console.WriteLine("Результат" + String.Concat(Enumerable.Repeat(" ", 65)) + "*");
        Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

        if (ds.CheckNumber(value) == true)
        {
            Console.WriteLine("Строка - натуральное число.");
        }
        else
        {
            Console.WriteLine("Строка - не натуральное число.");
        }

        Console.ReadKey();
    }
}