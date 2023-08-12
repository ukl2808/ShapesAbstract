public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area => Width * Height;
    public override double Perimeter => 2 * (Width + Height);

    public override string ToString()
    {
        return $"Прямоугольник: Ширина = {Width}, Высота = {Height}, Площадь = {Area}, Периметр = {Perimeter}";
    }
}