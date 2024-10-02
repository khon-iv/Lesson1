using LessonTask1;
using LessonTask2;
using LessonTask3;
using LessonTask5;
using LessonTask6;
using MethodsClassLibrary;
using Task4;

namespace Lesson1;

class Lesson1
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a number: ");
            var numberOfTask = MethodsClass.GetNumberInRange(1, 6);
            
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
            }
        }
    }
    
    
}