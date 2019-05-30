using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRP
{
    class Shape
    {
        public Rectangle draw(int xTopLeft, int yTopLeft)
        {
            xUpperLeftCorner = xTopLeft;
            yUpperLeftCorner = yTopLeft;
            Rectangle rect = new Rectangle(xUpperLeftCorner, yUpperLeftCorner, width, height);
            return rect;
        }

        public void paint(Graphics g)
        {
            Pen myPen = new Pen(Color.Black);
            g.DrawRectangle(myPen, draw(150, 150));
        }

        private int xUpperLeftCorner = 0;
        private int yUpperLeftCorner = 0;
        private int width = 200;
        private int height = 100;

        public int getShapeY()
        {
            return yUpperLeftCorner;
        }

        public int getShapeX()
        {
            return xUpperLeftCorner;
        }

        public int getShapeHeight()
        {
            return height;
        }

        public int getShapeWidth()
        {
            return width;
        }
    }
}
