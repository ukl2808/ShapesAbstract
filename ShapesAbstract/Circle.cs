public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area => Math.PI * Radius * Radius;
    public override double Perimeter => 2 * Math.PI * Radius;

    public override string ToString()
    {
        return $"Круг: Радиус = {Radius}, Площадь = {Area}, Периметр = {Perimeter}";
    }
}