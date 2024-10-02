namespace LessonTask;

public abstract class TaskBaseClass
{
    protected abstract string Name { get; set; }
    protected abstract string Description { get; set; }
    public abstract void Run();

    protected TaskBaseClass()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Description + "\n");
    }
}