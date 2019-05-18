using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    class Painter
    {
        private List<object> shapes;

        public Painter(List<object> shapesToDraw)
        {
            shapes = shapesToDraw;
        }

        public void paintComponent(Graphics g)
        {
            for(int i=0; i<shapes.Count(); i++)
            {
                Shape shape = (Shape)shapes[i];
                shape.draw(g);
            }
        }
    }
}
