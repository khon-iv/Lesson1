using LessonTask1;
using LessonTask2;
using LessonTask3;
using LessonTask4;
using LessonTask5;
using LessonTask6;
using LessonTask7;
using LessonTask8;
using LessonTask9;
using LessonTask10;
using LessonTask11;
using MethodsClassLibrary;

namespace Lesson1;

class Lesson1
{
    static void Main(string[] args)
    {
        var numberOfTask = MethodsClass.GetNumber("Введите номер задания",1, 11);
        while (true)
        {
            switch (numberOfTask)
            {
                case 1: 
                    (new Task1Class()).Run();
                    break;
                case 2:
                    (new Task2Class()).Run();
                    break;
                case 3: 
                    new Task3Class().Run();
                    break;
                case 4: 
                    new Task4Class().Run();
                    break;
                case 5: 
                    new Task5Class().Run();
                    break;
                case 6: 
                    new Task6Class().Run();
                    break;
                case 7: 
                    new Task7Class().Run();
                    break;
                case 8: 
                    new Task8Class().Run();
                    break;
                case 9: 
                    new Task9Class().Run();
                    break;
                case 10: 
                    new Task10Class().Run();
                    break;
                case 11: 
                    new Task11Class().Run();
                    break;
            }
            
            numberOfTask = MethodsClass.GetNumber("\nВведите номер задания",1, 11);
        }
    }
    
    
}