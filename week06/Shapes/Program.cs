using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> allShapes = new List<Shapes>();

        Square mySquare = new Square("Yellow", 5.0);
        allShapes.Add(mySquare);
        
        Rectangle myRect = new Rectangle("Blue", 2.0, 4.0);
        allShapes.Add(myRect);

        Circle myCircle = new Circle("Green", 2.3);
        allShapes.Add(myCircle);

        foreach (Shapes shape in allShapes)
        {
            string color = shape.GetColor();

            double shapeArea = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {shapeArea}");
        }

    }
}