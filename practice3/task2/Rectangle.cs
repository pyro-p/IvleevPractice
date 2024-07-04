

namespace practice3.task2;

public class Rectangle : Figure
{
    public Rectangle(bool filled, int width, int x, int y) : base(filled, width, x, y)
    {
        Height = width / 2;
        Filled = true;
    }

    public override void Draw(Pen pen, SolidBrush br, Graphics g)
    {
        pen = new Pen(Color.Black, 1);
        br = new SolidBrush(Color.Transparent);

        g.DrawRectangle(pen, StartPosX, StartPosY, Width, Height);
        if (Filled)
        {
            g.FillRectangle(br, StartPosX, StartPosY, Width, Height);
        }
    }
}
