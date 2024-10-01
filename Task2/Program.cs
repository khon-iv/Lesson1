namespace Task2;
class Program
{
    static void Main(string[] args)
    {
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