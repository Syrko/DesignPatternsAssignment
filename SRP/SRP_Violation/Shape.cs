using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRP_Violation
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

        private int xUpperLeftCorner = 0;
        private int yUpperLeftCorner = 0;
        private int width = 200;
        private int height = 100;

        public int getXLowerRightCorner()
        {
            return width;
        }

        public int getYLowerRightCorner()
        {
            return height;
        }
    }
}
