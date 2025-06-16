//Child Class - Square
public class Square : Shape
{
    public double Side { get; set; }

    public Square(string color, double side) : base(color)
    {
        Side = side;
    }

    public override double GetArea()
    {
        double area = Side * Side;
        return area;
    }
}
