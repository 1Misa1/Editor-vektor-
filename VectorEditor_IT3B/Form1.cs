using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
// udělat kruh point - canterpoint, float - radius, color - color potřebujeme drawelipse
// DÚ - aby se dal otevřít uloženej soubor, ať kreslí čáry
namespace VectorEditor_IT3B
{
    public partial class Form1 : Form
    {
        Shapes selectedShape = Shapes.None;
        List<Shape> shapes;
        Line tempLine;
        System.Drawing.Point mousePoint;
        Color defaultButtonColor;
        bool firstClick = true;

        public Form1()
        {
            InitializeComponent();
            shapes = new List<Shape>();
            defaultButtonColor = btnLine.BackColor;
        }

        private void pboxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.Location.ToString();
            mousePoint = e.Location;
            if (tempLine != null)
            {
                tempLine.Point2 = new Point(e.X, e.Y);
            }
            
            pboxCanvas.Refresh();
        }

        private void pboxCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedShape == Shapes.Point)
            {
                shapes.Add(new Point(e.Location.X, e.Location.Y));
            }
            else if (selectedShape == Shapes.Line)
            {
                if(firstClick)
                {
                    firstClick = false;
                    tempLine = new Line(new Point(e.X, e.Y), new Point(e.X, e.Y));
                }
                else
                {
                    firstClick = true;
                    tempLine.Point2 = new Point(e.X, e.Y);
                    shapes.Add(tempLine);
                    tempLine = null;
                }
                    
            }
            pboxCanvas.Refresh();

        }

        private void pboxCanvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
                
            }
            if (tempLine != null)
            {
                tempLine.Draw(e.Graphics);
            }
        }

        private void sfd_FileOk(object sender, CancelEventArgs e)
        {
            var json = JsonConvert.SerializeObject(shapes/*, Formatting.Indented*/);
            File.WriteAllText(sfd.FileName, json);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S && e.Control)
            {
                sfd.ShowDialog();
            }
            else if (e.KeyCode == Keys.O && e.Control)
            {
                ofd.ShowDialog();
            }
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            try
            {

                /* foreach(var shape in shapes)
                {
                    if(shape.GetType() == typeof(Point))
                    {

                    }
                }
                */
                var json = File.ReadAllText(ofd.FileName);
                shapes = JsonConvert.DeserializeObject<List<Shape>>(json);
                pboxCanvas.Refresh();
            }
            catch
            {
                MessageBox.Show("Nepodařilo se otevřít.");
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            selectedShape = Shapes.Point;
            btnPoint.BackColor = Color.LightBlue;
            btnLine.BackColor = defaultButtonColor; // knowcolor - systémové barvy
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            selectedShape = Shapes.Line;
            btnLine.BackColor = Color.LightBlue;
            btnPoint.BackColor = defaultButtonColor;
        }
    }
}
