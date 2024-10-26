using System.Text;

namespace AlgoSolutions.FirstLesson.FirstTask;

public class FirstTask
{

    public void TaskSolution(int x1, int y1, int x2, int y2, int x, int y)
    {
        StringBuilder str = new StringBuilder("");
        if (y > y2)
        {
            str.Append("N");
        }

        if (y < y1)
        {
            str.Append("S");
        }

        if (x > x2)
        {
            str.Append("E");
        }

        if (x < x1)
        {
            str.Append("W");
        }
        Console.WriteLine(str.ToString());
    }
}