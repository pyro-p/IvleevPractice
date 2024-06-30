namespace practice3.task2;

public class Oval : Figure
{
    public Oval(bool filled, int width) : base(filled, width)
    {
        Height = width / 2;
    }
}
