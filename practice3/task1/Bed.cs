using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3.task1;

public class Bed
{
    private string _size;
    private string _color;

    public void SetSize(string Size)
    {
        if (Size != "" && Size != null)
        {
            _size = Size;
        }
    }

    public void SetColor(string Color)
    {
        if (Color != "" && Color != null)
        {
            _color = Color;
        }
    }

    public string GetSize()
    {
        return _size;
    }

    public string GetColor()
    {
        return _color;
    }
}
