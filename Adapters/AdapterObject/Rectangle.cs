using System;

namespace AdapterObject
{
	class Rectangle : IShape
	{
		public void draw()
		{
			Console.WriteLine("Drawing Rectangle...");
		}
		public void resize()
		{
			Console.WriteLine("Resizing Rectangle...");
		}
		public String description()
		{
			return "Rectangle object";
		}
		public bool isHide()
		{
			return false;
		}
	}
}
