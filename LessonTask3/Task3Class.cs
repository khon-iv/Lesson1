using LessonTask;
using MethodsClassLibrary;

namespace LessonTask3;

public class Task3Class : TaskBaseClass
{
    protected override string Name { get; set; } = "Задание3. Задача копирование массива";
    protected override string Description { get; set; } = 
        "Напишите код для создания копии массива. " +
        "Сначала создайте исходный массив на 10 элементов с любым типом данных. " + 
        "Заполните его любыми значениями. Теперь создайте вторую переменную массива с таким же типом и длиной, как у исходного. " + 
        "Используйте цикл for для копирования данных их исходного массива в новый. " + 
        "Выведите в консоль содержимое обоих массивов, чтобы убедиться, что всё скопировалось правильно.";

    public override void Run()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        var arrayCopy = new int[10];

        for (var i = 0; i < 10; i++)
            arrayCopy[i] = array[i];

        Console.WriteLine("Элементы массива:");
        MethodsClass.PrintArray(array);

        Console.WriteLine("\nЭлементы массива-копии:");
        MethodsClass.PrintArray(arrayCopy);

    }
}