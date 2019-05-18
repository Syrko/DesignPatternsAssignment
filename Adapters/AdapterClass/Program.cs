using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClass
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Creating drawing of shapes...");
			Drawing drawing = new Drawing();
			drawing.addShape(new Rectangle());
			drawing.addShape(new Circle());
			drawing.addShape(new TriangleAdapter());
			drawing.addShape(new RhombusAdapter());
			Console.WriteLine("Drawing...");
			drawing.draw();
			Console.WriteLine("Resizing...");
			drawing.resize();

			Console.Read();
		}
	}
}
