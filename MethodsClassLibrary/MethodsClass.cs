namespace MethodsClassLibrary;

public static class MethodsClass
{
    public static int GetNumber(string message, int min = Int32.MinValue, int max = Int32.MaxValue)
    {
        Console.WriteLine(message);
        var inputLine = Console.ReadLine();
        while (!Int32.TryParse(inputLine, out int num))
        {
            Console.WriteLine("Введены некорректные данные \n");
            inputLine = Console.ReadLine();
        }

        var number = Int32.Parse(inputLine);
        if (number < min || number > max)
        {
            Console.WriteLine("Введены некорректные данные \n");
            number = GetNumber( message, min, max);
        }
        
        return number;
    }

    public static void PrintArray(int[] array)
    {
        foreach (var i in array)
            Console.Write(i + " ");
    }
}
    