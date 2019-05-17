using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClass
{
	class Circle: Shape
	{
		public void draw()
		{
			Console.WriteLine("Drawing Circle");
		}
		public void resize()
		{
			Console.WriteLine("Resizing Circle");
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
