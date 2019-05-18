using System;

namespace AdapterObject
{
	class Circle : IShape
	{
		public void draw()
		{
			Console.WriteLine("Drawing Circle...");
		}
		public void resize()
		{
			Console.WriteLine("Resizing Circle...");
		}
		public String description()
		{
			return "Circle object";
		}
		public bool isHide()
		{
			return false;
		}
	}
}
