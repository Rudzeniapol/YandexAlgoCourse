using System.Text;

namespace AlgoSolutions.FirstLesson.FirstTask;

public class FirstTask
{

    public void TaskSolution(int x1, int y1, int x2, int y2, int x, int y)
    {
        StringBuilder str = new StringBuilder("");
        if (y > y2)
        {
            str.Append("S");
        }

        if (y < y1)
        {
            str.Append("N");
        }

        if (x > x2)
        {
            str.Append("W");
        }

        if (x < x1)
        {
            str.Append("E");
        }
    }
}