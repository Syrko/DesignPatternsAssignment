using System;
using System.Collections.Generic;

namespace AdapterObject
{
	class Drawing
	{
		List<IShape> shapes;
		public Drawing()
		{
			shapes = new List<IShape>();
		}
		public void addShape(IShape shape)
		{
			shapes.Add(shape);
		}
		public List<IShape> getShapes()
		{
			return new List<IShape>(shapes);
		}
		public void draw()
		{
			if (shapes.Count == 0)
			{
				Console.WriteLine("Nothing to draw!");
			}
			else
			{
				foreach(IShape shape in shapes)
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
				foreach (IShape shape in shapes)
				{
					shape.resize();
				}
			}
		}
	}
}
