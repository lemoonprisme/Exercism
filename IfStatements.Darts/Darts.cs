namespace IfStatements.Darts;

public class Darts
{
    public static int Score(double x, double y)
    {
        return Math.Sqrt(x*x+y*y) switch{
            <= 1d => 10,
            <= 5d => 5,
            <= 10d => 1,
            _ => 0
        };
    }
}