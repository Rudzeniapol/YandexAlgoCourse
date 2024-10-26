namespace AlgoSolutions;

public class Testing
{
    private StreamReader _reader;
    public Testing(string? path)
    {
        if (path != null && File.Exists(path))
        {
            _reader = new StreamReader(path);
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }

    public void RunFirstTaskTests()
    {
        if (_reader != StreamReader.Null)
        {
            int x1, y1, x2, y2, x, y, count;
            count = 1;
            while (!_reader.EndOfStream)
            {
                x1 = int.Parse(_reader.ReadLine());
                y1 = int.Parse(_reader.ReadLine());
                x2 = int.Parse(_reader.ReadLine());
                y2 = int.Parse(_reader.ReadLine());
                x = int.Parse(_reader.ReadLine());
                y = int.Parse(_reader.ReadLine());
                Console.WriteLine($"{count++} Test:");
                FirstLesson.FirstTask.FirstTask task = new FirstLesson.FirstTask.FirstTask();
                task.TaskSolution(x1, y1, x2, y2, x, y);
            }
        }
        else
        {
            Console.WriteLine("Cannot run tests for the task.");
        }
    }
}