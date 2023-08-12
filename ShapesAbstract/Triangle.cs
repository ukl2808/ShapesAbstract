public class Triangle : Shape
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public override double Area
    {
        get
        {
            double p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
    }

    public override double Perimeter => Side1 + Side2 + Side3;

    public override string ToString()
    {
        return $"Треугольник: Сторона1 = {Side1}, Сторона2 = {Side2}, Сторона3 = {Side3}, Площадь = {Area}, Периметр = {Perimeter}";
    }
}