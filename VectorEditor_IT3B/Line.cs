using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace VectorEditor_IT3B
{
    public abstract class Line : Shape
    {


        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Color Color { get; set; }
        public int LineWidth { get; set; }

        protected Line(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
            Color = Color.Black;
            LineWidth = 1;
        }

        protected Line(Point point1, Point point2, Color color, int lineWidth)
        {
            Point1 = point1;
            Point2 = point2;
            Color = color;
            LineWidth = lineWidth;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(new Pen(Color, LineWidth), Point1.X, Point1.Y, Point2.X, Point2.Y);
            Point1.Draw(graphics);
            Point2.Draw(graphics);
        }

    }
}
