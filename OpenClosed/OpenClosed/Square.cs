using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    class Square : Shape
    {
        Pen myPen = new Pen(Color.Black);
        private int topLeftX=10;
        private int topLeftY=10;
        private int width=100;
        public Square(int x, int y, int itsWidth)
        {
            topLeftX = x;
            topLeftY = y;
            width = itsWidth;
        }
        override public void draw(Graphics g)
        {
            Rectangle rect = new Rectangle(topLeftX, topLeftY, width, width);
            g.DrawRectangle(myPen, rect);
        }
    }
}
