using System.Windows.Forms;

namespace practice3.task2;

public abstract class Figure
{
    public bool Filled { get; protected set; }
    public int Height { get; protected set; }
    public int Width { get; protected set; }
    public int StartPosX { get; protected set; }
    public int StartPosY { get; protected set; }

    public Figure(bool filled, int width, int x, int y)
    {
        Filled = filled;
        Width = width;
        Height = width;
        StartPosX = x;
        StartPosY = y;
    }

    public void CreateTools(int pictureWidth, int pictureHeight, Bitmap bmp)
    {
        Graphics g = Graphics.FromImage(bmp);
        Pen pen = null;
        SolidBrush brush = null;

        Draw(pen, brush, g);
    }

    public abstract void Draw(Pen pen, SolidBrush br, Graphics g);
}