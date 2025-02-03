//Written by Ibrahim Traore
//02/02/25


using System;

class Triangle
{
    //properties for base and height
    public double BaseLength { get; set; }
    public double Height { get; set; }

    //constructor to initialize the triangle's base and height
    public Triangle(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }

    //method to calculate the area
    public double CalculateArea()
    {
        return (BaseLength * Height) / 2;
    }
}

