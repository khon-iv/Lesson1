using LessonTask;
using MethodsClassLibrary;

namespace LessonTask5;

public class Task5Class : TaskBaseClass
{
    protected override string Name { get; set; } = "Задание5. Задача перечисление месяцев";
    protected override string Description { get; set; } = 
        "Используя перечисление (enum) DaysOfWeek в качестве примера, создайте перечисление для представления месяцев года. " +
        "Присвойте им значения от 1 до 12. Напишите программу, которая попросит пользователя ввести число от 1 до 12. Убедитесь, " +
        "что пользователь ввёл значение в нужном диапазоне и используйте явное приведение типа для преобразования числа в созданный вами enum. " +
        "Затем выведите название месяца в консоль.";
    
    public override void Run()
    {
        PrintTaskInfo();
        var month = (Months)GetNumberOfMonth();
        Console.WriteLine(month);
    }
    
    static int GetNumberOfMonth()
    {
        Console.WriteLine("Введите число от 1 до 12");
        var monthNumber = MethodsClass.GetNumberInRange(1, 12);
        return monthNumber;
    }
    enum Months
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