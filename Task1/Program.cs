using System;

namespace Task1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число");
        int a = GetNumber();
        Console.WriteLine("Введите второе число");
        int b = GetNumber();
        
        Console.WriteLine($"{a}/{b} = {a / b} остаток {a % b}");

    }

    static int GetNumber()
    {
        var inputLine = Console.ReadLine();
        while (!Int32.TryParse(inputLine, out int num))
        {
            Console.WriteLine("Введенная строка не является числом \nВведите первое число");
            inputLine = Console.ReadLine();
        }

        return Int32.Parse(inputLine);
    }
}