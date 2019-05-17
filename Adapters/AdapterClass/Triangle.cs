using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClass
{
	class Triangle : GeometricShape
	{
		private double a;
		private double b;
		private double c;
		public Triangle() : this(1.0d, 1.0d, 1.0d) { }
		public Triangle(double a, double b, double c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
		}
		public double area()
		{
			// Heron's formula:
			// Area = SquareRoot(s * (s - a) * (s - b) * (s - c)) 
			// where s = (a + b + c) / 2, or 1/2 of the perimeter of the triangle 
			double s = (a + b + c) / 2;
			return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
		}
		public double perimeter()
		{
			// P = a + b + c
			return a + b + c;
		}
		public void drawShape()
		{
			Console.WriteLine("Drawing Triangle with area: " + area() + " and perimeter: " + perimeter());
		}
	}
}
