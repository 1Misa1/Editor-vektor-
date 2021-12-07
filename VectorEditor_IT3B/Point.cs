using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace VectorEditor_IT3B
{
    public class Point: Shape /// : něco je dědičnost
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Color Color { get; set; }
        public int Diameter { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
            Color = Color.Black;
            Diameter = 8;

        }
        public Point(float x, float y)
        {
            X = x;
            Y = y;
            Color = Color.Black;
            Diameter = 8;
        }
        public Point(float x, float y, Color color, int diameter)
        {
            X = x;
            Y = y;
            this.Color = color;
            Diameter = diameter;
        }

      

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(Color), X - Diameter / 2, Y - Diameter / 2, Diameter, Diameter);
        }

    }
}
