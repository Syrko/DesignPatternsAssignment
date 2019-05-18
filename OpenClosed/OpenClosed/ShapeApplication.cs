using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OpenClosed
{
    class ShapeApplication
    {
        public ShapeApplication(Graphics g) {
            Square S1 = new Square(50, 50, 50);
            Circle C1 = new Circle(100, 100, 40);
            Circle C2 = new Circle(200, 100, 20);
            List<object> shapes = new List<object>();

            shapes.Add(S1);
            shapes.Add(C1);
            shapes.Add(C2);
            Painter myPainter = new Painter(shapes);
            myPainter.paintComponent(g);
        }

    }
}
