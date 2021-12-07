using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace VectorEditor_IT3B
{
    public abstract class Shape
    {
        public abstract void Draw(Graphics graphics); // pokuď něco chce dědit třídu musí mít Draw, virutal muže mít nadřazenou třídu, abstract ne 
    }

    public enum Shapes //jakoby výběr
    {
        None,
        Point,
        Line
    }
}
