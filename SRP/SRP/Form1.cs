using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Shape myShape = new Shape();
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            g.DrawRectangle(myPen, myShape.draw(150, 150));
            GeometricShape myGeoShape = new GeometricShape(myShape);
            Console.WriteLine("Lower Right Corner. X: " + myGeoShape.getXLowerRightCorner() + " Y: " + myGeoShape.getYLowerRightCorner());
        }
    }
}
