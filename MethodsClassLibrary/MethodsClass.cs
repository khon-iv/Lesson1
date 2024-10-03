namespace MethodsClassLibrary;

public static class MethodsClass
{
    public static void PrintTaskInfo(string taskName, string taskDescription)
    {
        Console.WriteLine(taskName);
        Console.WriteLine(taskDescription + "\n");
    }
    
    public static int GetNumber(string message, int min = Int32.MinValue, int max = Int32.MaxValue)
    {
        Console.WriteLine(message);
        var inputLine = Console.ReadLine();
        while (!Int32.TryParse(inputLine, out int num))
        {
            Console.WriteLine("Введенное значение не является числом");
            inputLine = Console.ReadLine();
        }

        var number = Int32.Parse(inputLine);
        if (number < min || number > max)
        {
            Console.WriteLine("Введено некорректное число");
            number = GetNumber( message, min, max);
        }
        
        return number;
    }

    public static void PrintArray(int[] array)
    {
        foreach (var i in array)
            Console.Write(i + " ");
    }
    
    public enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
    