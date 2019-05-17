using System;
using System.Collections.Generic;

namespace AdapterClass
{
	class Drawing
	{
		List<Shape> shapes;
		public Drawing()
		{
			shapes = new List<Shape>();
		}
		public void addShape(Shape shape)
		{
			shapes.Add(shape);
		}
		public List<Shape> getShapes()
		{
			return new List<Shape>(shapes);
		}
		public void draw()
		{
			if (shapes.Count == 0)
			{
				Console.WriteLine("Nothing to draw!");
			}
			else
			{
				foreach (Shape shape in shapes)
				{
					shape.draw();
				}
			}
		}
		public void resize()
		{
			if (shapes.Count == 0)
			{
				Console.WriteLine("Nothing to resize!");
			}
			else
			{
				foreach (Shape shape in shapes)
				{
					shape.resize();
				}
			}
		}
	}
}
