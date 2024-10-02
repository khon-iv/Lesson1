namespace LessonTask;

public abstract class TaskBaseClass
{
    protected abstract string Name { get; set; }
    protected abstract string Description { get; set; }

    protected void PrintTaskInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Description + "\n");
    }
    public abstract void Run();
}