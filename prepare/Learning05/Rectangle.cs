public class Rectangle : Shape
{
    public double Length { get; set; }

    public double Width { get; set; }

    public Rectangle(string color, double length, double width) : base(color)
    {
        Length = length;
        Width = width;
    }

    public override double GetArea()
    {
        double area = Length * Width;
        return area;
    }
}
