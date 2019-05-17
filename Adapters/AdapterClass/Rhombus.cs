using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClass
{
	class Rhombus : GeometricShape
	{
		private double a;
		private double b;
		public Rhombus() : this(1.0d, 1.0d) { }
		public Rhombus(double a, double b)
		{
			this.a = a;
			this.b = b;
		}
		public double area()
		{
			double s = a * b;
			return s;
		}
		public double perimeter()
		{
			return 2 * (a + b);
		}
		public void drawShape()
		{
			Console.WriteLine("Drawing Rhombus with area: " + area() + " and perimeter: " + perimeter());
		}
	}
}
