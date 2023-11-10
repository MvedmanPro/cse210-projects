using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)

    
    {
         List<Shape> shapes = new List<Shape>();

        RectangleShape rShape = new RectangleShape("Purple", 5, 6);
        shapes.Add(rShape);

        SquareShape sShape = new SquareShape("Orange", 8);
        shapes.Add(sShape);

        CircleShape cShape = new CircleShape("Yellow", 9);
        shapes.Add(cShape);


        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }



    }
}