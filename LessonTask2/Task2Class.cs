using LessonTask;

namespace LessonTask2
{
    public class Task2Class : TaskBaseClass
    {
        protected override string Name { get; set; } = "Задание2. Задача FizzBuzz";
        protected override string Description { get; set; } = 
            "Задача состоит в том, чтобы вывести все числа от 1 до 100. Но если число является кратным 3, " +
            "вместо него следует вывести слово «Fizz». Если число кратно 5, выводим «Buzz». Если число кратно как 3, " +
            "так и 5 (например, 15 или 30), то выводим «FizzBuzz»";
        
        public override void Run()
        {
            PrintTaskInfo();
            for (int i = 1; i < 101; i++)
            {
                if (i % 15 == 0)
                    Console.Write("FizzBizz ");
                else if (i % 3 == 0)
                    Console.Write("Fizz ");
                else if (i % 5 == 0)
                    Console.Write("Bizz ");
                else
                    Console.Write(i + " ");
            }
        }
    }
}