namespace practice3.task3;

public class CalculateChild : Calculate
{
    public override int GetResult(int x, int y)
    {
        return (x - y) * (x - y);
    }
}
