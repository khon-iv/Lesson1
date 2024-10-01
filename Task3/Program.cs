namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        var arrayCopy = new int[10];

        for (var i = 0; i < 10; i++)
            arrayCopy[i] = array[i];

        Console.WriteLine("Элементы массива:");
        PrintArray(array);

        Console.WriteLine("\nЭлементы массива-копии:");
        PrintArray(arrayCopy);

    }

    private static void PrintArray(int[] arr)
    {
        foreach (var i in arr)
            Console.Write(i + " ");
    }
}