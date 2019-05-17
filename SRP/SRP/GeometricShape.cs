using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class GeometricShape
    {
        public GeometricShape(Shape theShape)
        {
            drawnShape = theShape;
        }

        public int getXLowerRightCorner()
        {
            return drawnShape.getShapeX() + drawnShape.getShapeWidth();
        }

        public int getYLowerRightCorner()
        {
            return drawnShape.getShapeY() + drawnShape.getShapeHeight();
        }

        private Shape drawnShape;
    }
}
