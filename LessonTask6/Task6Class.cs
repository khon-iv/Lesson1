using LessonTask;
using MethodsClassLibrary;

namespace LessonTask6;

public class Task6Class : TaskBaseClass
{
    protected override string Name { get; set; } =
        "Задача6. Задача перевернуть массив";
    protected override string Description { get; set; } = 
        "Давайте сделаем программу, которая использует методы для выполнения задачи. " +
        "Давайте возьмем массив и перевернём его содержимое в обратном порядке. " +
        "Например, если у вас массив 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, то результатом будет 10, 9, 8, 7, 6, 5, 4, 3, 2, 1. " +
        "Чтобы добиться этого, вы создадите три метода: один для создания массива, " +
        "один для его переворачивания и один для вывода массива в конце.\n" +
        "Метод GenerateNumbers должен вернуть массив из 10 случайных чисел (бонусное условие - метод должен принимать в качестве аргумента длину желаемого массива). " +
        "Метод PrintNumbers должен использовать цикл for или foreach для вывода каждого элемента массива. " +
        "Метод Reverse будет делать основную работу - переворачивать массив.\n\nРеализуйте все три метода.";

    public override void Run()
    {
        Console.WriteLine("Введите размер массива");
        var arraySize = MethodsClass.GetNumber();
        var numbers = GenerateNumbers(arraySize);
        Console.WriteLine("Сгенерированный массив:");
        PrintNumbers(numbers);
        Console.WriteLine();
        Reverse(ref numbers);
        PrintNumbers(numbers);
    }
    private static int[] GenerateNumbers(int arraySize = 10)
    {
        var random = new Random();
        int[] numbers = new int[arraySize];
        for (var i = 0; i < arraySize; i++)
        {
            numbers[i] = random.Next();
        }
        
        return numbers;
    }

    private static void Reverse(ref int[] numbers)
    {
        for (var i = 0; i < numbers.Length / 2; i++)
        {
            var temp = numbers[i];
            numbers[i] = numbers[numbers.Length - i - 1];
            numbers[numbers.Length - i - 1] = temp;
        }
    }

    private static void PrintNumbers(int[] numbers)
    {
        foreach (var number in numbers)
            Console.Write(number + "\t");
    }
}