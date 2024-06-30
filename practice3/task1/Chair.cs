using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3.task1;

public class Chair
{
    private string _material;
    private string _color;

    public void SetMaterial(string Material)
    {
        _material = Material;
    }

    public void SetColor(string Color)
    {
        _color = Color;
    }

    public string GetMaterial()
    {
        return _material;
    }

    public string GetColor()
    {
        return _color;
    }
}
