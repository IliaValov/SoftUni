using System;
using System.Collections.Generic;
using System.Text;


class Circle
{
    public Circle(double radius, Point point)
    {
        Radius = radius;
        Point = point;
    }

    public double Radius{get; set;}
    public Point Point{get; set;}

}

