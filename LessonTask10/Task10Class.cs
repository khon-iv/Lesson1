using System.Reflection;
using LessonTask;
using MethodsClassLibrary;

namespace LessonTask10;

public class Task10Class : TaskBaseClass
{
    protected override string Name { get; set; } = "Дни месяца";
    protected override string Description { get; set; } =
        "Составить программу, которая в зависимости от порядкового номера месяца (1, 2, ..., 12) и года " +
        "выводит на экран количество дней в этом месяце. При вычисление количества дней учесть високосный год.\n" +
        "Год является високосным, если его номер кратен 4, однако из кратных 100 високосными являются лишь кратные 400," +
        " например, 1700, 1800 и 1900 — невисокосные года, 2000 — високосный. \nУсловия и ограничения:\n" +
        "Значение номера месяца и год должны вводиться через стандартный ввод\n" +
        "Результаты вычисления вывести в стандартный вывод\nДобавить проверку на корректность ввода данных";
    
    public override void Run()
    {
        PrintTaskInfo();
        var monthNumber = MethodsClass.GetNumber("Введите прорядковый номер месяца (число от 1 до 12)", 1, 12);
        
        switch (monthNumber)
        {
            case 2:
                var year = MethodsClass.GetNumber("Введите год");
                if ((year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0)))
                    Console.WriteLine(29);
                else 
                    Console.WriteLine(28);
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine(30);
                break;
            default:
                Console.WriteLine(31);
                break;
        }
    }

}