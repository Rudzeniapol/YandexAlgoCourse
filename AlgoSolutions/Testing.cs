namespace AlgoSolutions;

public class Testing
{
    private StreamReader reader;
    public Testing(string path)
    {
        if (File.Exists(path))
        {
            reader = new StreamReader(path);
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }

    public void RunFirstTaskTests()
    {
        int x1, y1, x2, y2, x, y, count;
        count = 1;
        string line;
        while (!reader.EndOfStream)
        {
            x1 = int.Parse(reader.ReadLine());
            y1 = int.Parse(reader.ReadLine());
            x2 = int.Parse(reader.ReadLine());
            y2 = int.Parse(reader.ReadLine());
            x = int.Parse(reader.ReadLine());
            y = int.Parse(reader.ReadLine());
            Console.WriteLine($"{count++} Test:");
            FirstLesson.FirstTask.FirstTask task = new FirstLesson.FirstTask.FirstTask();
            task.TaskSolution(x1, y1, x2, y2, x, y);
        }
    }
}