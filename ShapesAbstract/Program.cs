Shape[] shapes = new Shape[]
{
            new Rectangle { Width = 5, Height = 3 },
            new Circle { Radius = 4 },
            new Triangle { Side1 = 3, Side2 = 4, Side3 = 5 }
};

PrintShapesInfo(shapes);

static void PrintShapesInfo(Shape[] shapes)
{
    foreach (Shape shape in shapes)
    {
        Console.WriteLine(shape.ToString());
    }
}