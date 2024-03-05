﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse.Exercise25
{
    public static class Exercise25
    {
        public static List<double> GetShapesAreas(List<Shape> shapes)
        {
            var result = new List<double>();

            foreach (var shape in shapes)
            {
                result.Add(shape.CalculateArea());
            }

            return result;
        }
    }

    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Square : Shape
    {
        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }

        public override double CalculateArea()
        {
            return Side * Side;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
