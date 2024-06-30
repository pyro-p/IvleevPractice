namespace practice3.task2;

public abstract class Figure
{
    public bool Filled { get; protected set; }
    public int Height { get; protected set; }
    public int Width { get; protected set; }

    public Figure(bool filled, int width)
    {
        Filled = filled;
        Width = width;
        Height = width;
    }
}
