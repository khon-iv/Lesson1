namespace MethodsClassLibrary;

public static class MethodsClass
{
    public static int GetNumber()
    {
        var inputLine = Console.ReadLine();
        while (!Int32.TryParse(inputLine, out int num))
        {
            Console.WriteLine("Введенная строка не является числом \nВведите число");
            inputLine = Console.ReadLine();
        }

        return Int32.Parse(inputLine);
    }

    public static int GetNumberInRange(int min, int max)
    {
        var number = GetNumber();
        while (number < min || number > max)
        {
            number = GetNumber();
        }
        return number;
    }

    public static void PrintArray(int[] array)
    {
        foreach (var i in array)
            Console.Write(i + " ");
    }
}
    