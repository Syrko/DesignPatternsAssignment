using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterObject
{
	class Program
	{
		static void Main(string[] args)
		{
			// Original main
			Console.WriteLine("Original main: \n");

			Console.WriteLine("Creating drawing of shapes...");
			Drawing drawing = new Drawing();
			drawing.addShape(new Rectangle());
			drawing.addShape(new Circle());
			Console.WriteLine("Drawing...");
			drawing.draw();
			Console.WriteLine("Resizing...");
			drawing.resize();

			// Object Adapter main
			Console.WriteLine("\n=========================================\n");
			Console.WriteLine("Object adapter main: \n");

			Console.WriteLine("Creating drawing of shapes...");
			drawing = new Drawing();
			drawing.addShape(new Rectangle());
			drawing.addShape(new Circle());
			drawing.addShape(new GeometricShapeObjectAdapter(new Triangle()));
			drawing.addShape(new GeometricShapeObjectAdapter(new Rhombus()));
			Console.WriteLine("Drawing...");
			drawing.draw();
			Console.WriteLine("Resizing...");
			drawing.resize();

			Console.Read();
		}
	}
}
