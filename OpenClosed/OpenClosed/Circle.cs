using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    class Circle : Shape
    {
        Pen myPen = new Pen(Color.Black);
        private int centerX;
        private int centerY;
        private int radius;

        public Circle(int x, int y, int itsRadius)
        {
            centerX = x;
            centerY = y;
            radius = itsRadius;
        }

        override public void draw(Graphics g)
        {
            g.DrawArc(myPen, centerX - radius, centerY - radius, radius * 2, radius * 2, 0, 360);
        }
    }
}
