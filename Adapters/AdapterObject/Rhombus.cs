using System;

namespace AdapterObject
{
	class Rhombus : IGeometricShape
	{
		private double a;
		private double b;
		public Rhombus() : this(1.0d, 1.0d){}
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
