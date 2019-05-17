using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClass
{
	class TriangleAdapter: Triangle, Shape
	{
		public void draw()
		{
			this.drawShape();
		}
		public void resize()
		{
			Console.WriteLine("Triangle can't be resized. Please create new one with required values.");
		}
		public string description()
		{
			return "Triangle object";
		}
		public bool isHide()
		{
			return false;
		}

	}
}
