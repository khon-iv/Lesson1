using System.Reflection;
using LessonTask;
using MethodsClassLibrary;

namespace LessonTask8;


public class Task8Class: TaskBaseClass
{
    protected override string Name { get; set; } =
        "Зарплата";

    protected override string Description { get; set; } =
        "В двумерном массиве хранится информация о зарплате 7ми человек за каждый месяц года (за январь — в первом столбце, за февраль — во втором и т. д.).\n" +
        "Определить общую зарплату, выплаченную в выбранном месяце.\n" +
        "Условия и ограничения:\nЭлементы массива заранее заданы в коде программы\n" +
        "Месяц, на который требуется рассчитать зарплату, должен вводиться через стандартный ввод";

    public override void Run()
    {
        PrintTaskInfo();

        int[,] employeeSalaryArray = new int[7, 12]
        {
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12},
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12},
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12},
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12},
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12},
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12},
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}
        };
        var monthNumber = MethodsClass.GetNumber("Введите прорядковый номер месяца (число от 1 до 12)", 1, 12);

        int sumOfSalaryByMonth = 0;
        
        for (int i = 0; i <= employeeSalaryArray.GetUpperBound(0); i++)
        {
            sumOfSalaryByMonth += employeeSalaryArray[i, monthNumber - 1];
        }
        
        Console.WriteLine($"Общая зарплата сотрудников в {(MethodsClass.Months)monthNumber}: {sumOfSalaryByMonth}");
    }
}