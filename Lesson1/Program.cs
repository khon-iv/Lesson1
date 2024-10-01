using Task1;
using Task2;
using Task3;
using Task4;
using Task5;
using Task6;
using MethodsLibrary;

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