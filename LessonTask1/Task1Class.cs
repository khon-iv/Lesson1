﻿using System.Security.Cryptography;
using LessonTask;
using MethodsClassLibrary;

namespace LessonTask1
{
    public class Task1Class : TaskBaseClass
    {
        protected override string Name { get; set; }  = "Задание1. Задача остаток от деления";
        protected override string Description { get; set; }  = 
            "Напишите простую программу для вывода результатов операции деления.\n" +
            "Создайте две целочисленные переменные - a и b.\n" +
            "Создайте третью целочисленную переменную, называемую quotient (результат деления), " +
            "которая хранит результат деления a и b, и еще одну целочисленную переменную под названием remainder, " +
            "которая хранит остаток (используя оператор %)." +
            "\nВыведите результаты с помощью Console.WriteLine или Console.Write в следующем формате " +
            "(при условии что a = 17 и b = 4): 17/4 = 4 остаток 1";

        public override void Run()
        {
            PrintTaskInfo();
            int a = MethodsClass.GetNumber("Введите первое число");
            int b = MethodsClass.GetNumber("Введите второе число (не 0)");
            while (b == 0)
            {
                Console.WriteLine("Нельзя делить на 0");
                b = MethodsClass.GetNumber("Введите второе число (не 0)");
            }
            
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} = {quotient} остаток {remainder}");
        }
    }
}

