using LessonTask;

namespace Task4;

public class Task4Class : TaskBaseClass
{
    protected override string Name { get; set; } = "Задание4. Задача минимальное и среднее значение";

    protected override string Description { get; set; } =
        "Создайте целочисленный массив и заполните его любыми значениями.\n" +
        "Выведите в консоль минимальное значение в массиве и среднее значение.\n" +
        "Для обхода используйте foreach.";

    public override void Run()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        var minValue = array[0];
        var sum = 0;

        foreach (var i in array)
        {
            sum += i;
            if (minValue > i)
                minValue = i;
        }

        Console.WriteLine($"Все элементы массива: {string.Join(' ', array)}");
        Console.WriteLine($"Минимальное значение в массиве: {minValue}");
        Console.WriteLine($"Среднее значение: {(double)sum / array.Length}");
    }
}