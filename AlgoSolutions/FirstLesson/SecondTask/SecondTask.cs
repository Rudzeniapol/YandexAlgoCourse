namespace AlgoSolutions.FirstLesson.SecondTask;

public class SecondTask
{
    public void TaskSolution(ulong a, ulong b, ulong c, ulong d)
    {
        ulong min, max1, max2;
        max1 = (a > b ? a : b);
        max2 = (c > d ? c : d);
        min = max1 > max2 ? max2 : max1;
        if (b == 0 || d == 0)
        {
            Console.WriteLine($"{b + 1} {d + 1}");
        }
        else if (a == 0 || c == 0)
        {
            Console.WriteLine($"{a + 1} {c + 1}"); 
        }
        else if (a == b)
        {
            Console.WriteLine($"{a + 1} {1}");
        }
        else if (c == d)
        {
            Console.WriteLine($"{1} {d + 1}");
        }
        else if ((min < a + c) && (min != a) && (min != c)) 
        {
            Console.WriteLine($"{(min == b ? (b + 1) : 1)} {((min == d && min != b) ? (d + 1) : 1)}");
        }
        else if ((min < b + d) && (min != b) && (min != d))
        {
            Console.WriteLine($"{(min == a ? (a + 1) : 1)} {((min == c && min != a) ? (c + 1) : 1)}");    
        }
        else
        {
            if(a + c < b + d)
            {
                Console.WriteLine($"{a + 1} {c + 1}");
            }
            else{
                Console.WriteLine($"{b + 1} {d + 1}");
            }
        }                 
    }
}