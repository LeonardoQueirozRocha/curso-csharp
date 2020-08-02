using System;
using AbstractExample.Entities.Enums;

namespace AbstractExample.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }
        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}