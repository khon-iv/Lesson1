using LessonTask;
using MethodsClassLibrary;

namespace LessonTask7;

public class Task7Class : TaskBaseClass
{
    protected override string Name { get; set; } =
        "Два автомобиля";

    protected override string Description { get; set; } =
        "Два автомобиля едут друг за другом с постоянными скоростями V1 и V2 км/час. " +
        "Определить, какое расстояние будет между ними через 30 минут после того, как первый автомобиль опередил второй на S км.\n" +
        "Условия и ограничения:\n" +
        "Значения V1, V2, S - должны вводиться через стандартный ввод.\n" +
        "Результат вывести в стандартный вывод.";

    public override void Run()
    {
        PrintTaskInfo();
        // минимальная скорость 0 максимальная 300
        var V1 = MethodsClass.GetNumber("Введите скорость первого автомобиля V1 (от 0 до 300)", 0, 300);
        var V2 = MethodsClass.GetNumber("Введите скорость второго автомобиля V2 (от 0 до 300)", 0, 300);

        if (V1 <= V2)
        {
            Console.WriteLine("Первый автомобиль никогда не опередит второй");
        }
        else
        {
            Console.WriteLine("Введите расстояние, на которое первый опередил второго S");
            var S = MethodsClass.GetNumber("Введите расстояние, на которое первый опередил второго S", 0);
            S += (V1 - V2) / 2;
            Console.WriteLine($"Расстояние между автомобилями через 30 минут: {S}");
        }
    }

}