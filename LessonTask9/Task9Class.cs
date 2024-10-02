using System.Reflection;
using LessonTask;
using MethodsClassLibrary;

namespace LessonTask9;

public class Task9Class : TaskBaseClass
{
    protected override string Name { get; set; } = "Вклады";
    protected override string Description { get; set; } = 
        "Гражданин 1го марта открыл счет в банке, вложив 1000 руб. " +
        "Через каждый месяц размер вклада увеличивается на 2% от имеющейся суммы. " +
        "Определить:\nприрост суммы вклада за первый, второй, ..., десятый месяц;\n" +
        "сумму вклада через три, четыре, ..., двенадцать месяцев\n" +
        "Условия и ограничения:\nЗначение числа должно вводиться через стандартный ввод" +
        "\nРезультаты вычисления вывести в стандартный вывод\nДля вычисления использовать рекурсию";

    private const double DepositRates = 2;
    private const int NumberForCalculateIncomeByMonths = 10;
    private const int NumberForCalculateAmountByMonths = 12;

    public override void Run()
    { 
        PrintTaskInfo();

        var firstDeposit = MethodsClass.GetNumber("Введите сумму первоначального взноса", 1);
        PrintIncomeByMonths(firstDeposit, NumberForCalculateIncomeByMonths);
        Console.WriteLine();
        PrintDepositAmountByMonths(firstDeposit, NumberForCalculateAmountByMonths);
    }

    private void PrintIncomeByMonths(double amount, int monthNumber)
    {
        Console.Write(Math.Round(amount * DepositRates * 0.01, 2));
        if (monthNumber > 1)
        {
            Console.Write("\t");
            PrintIncomeByMonths(Math.Round(amount + amount * DepositRates * 0.01), monthNumber - 1);
        }
    }
    
    private void PrintDepositAmountByMonths(double amount, int monthNumber)
    {
        Console.Write(Math.Round(amount + amount * DepositRates * 0.01, 2));
        if (monthNumber > 1)
        {
            Console.Write("\t");
            PrintDepositAmountByMonths(Math.Round(amount + amount * DepositRates * 0.01, 2), monthNumber - 1);
        }
    }
}