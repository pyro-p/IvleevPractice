

namespace practice3.task2;

public class Circle : Figure
{
    public Circle(bool filled, int width, int x, int y) : base(filled, width, x, y)
    {
    }

    public override void Draw(Pen pen, SolidBrush br, Graphics g)
    {
        pen = new Pen(Color.Black, 1);
        br = new SolidBrush(Color.Transparent);

        g.DrawEllipse(pen, StartPosX, StartPosY, Width, Height);
    }
}
