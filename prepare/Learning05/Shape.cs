using System.Drawing;

public abstract class Shape
{
    // private string _color;

    public Shape(string color)
    {
        Color = color;
    }

    public string Color { get; set; }

    public abstract double GetArea();

    public string GetColor()
    {
        return Color;
    }
}
