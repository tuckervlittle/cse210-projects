

public class Square : Shape
{
    private double _sideLength;

    public Square(double sideLength, string color) : base(color)
    {
        _sideLength = sideLength;
    }
    public override double Area()
    {
        return _sideLength * _sideLength;
    }
}