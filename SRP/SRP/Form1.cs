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
            Graphics g = e.Graphics;

            Shape myShape = new Shape();
            myShape.paint(g);
            GeometricShape myGeoShape = new GeometricShape(myShape);
            Console.WriteLine("Lower Right Corner. X: " + myGeoShape.getXLowerRightCorner() + " Y: " + myGeoShape.getYLowerRightCorner());
        }
    }
}
