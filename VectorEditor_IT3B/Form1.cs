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

namespace VectorEditor_IT3B
{
    public partial class Form1 : Form
    {
        List<PointF> points;
        Point mousePoint;

        public Form1()
        {
            InitializeComponent();
            points = new List<PointF>();
        }

        private void pboxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.Location.ToString();
            mousePoint = e.Location;
            //pboxCanvas.Refresh();
        }

        private void pboxCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(e.Location);
            pboxCanvas.Refresh();
        }

        private void pboxCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (points.Count > 2)
            {
                e.Graphics.DrawLines(Pens.Black, points.ToArray());
            }
            foreach (var point in points)
            {
                DrawPoint(e.Graphics, point);
            }
        }

        private void DrawPoint(Graphics g, PointF point)
        {
            int size = 10;
            g.FillEllipse(Brushes.Blue, point.X - size / 2, point.Y - size / 2, size, size);
        }

        private void sfd_FileOk(object sender, CancelEventArgs e)
        {
            var json = JsonConvert.SerializeObject(points/*, Formatting.Indented*/);
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
                var json = File.ReadAllText(ofd.FileName);
                points = JsonConvert.DeserializeObject<List<PointF>>(json);
                pboxCanvas.Refresh();
            }
            catch
            {
                MessageBox.Show("Nepodařilo se otevřít.");
            }
        }
    }
}
