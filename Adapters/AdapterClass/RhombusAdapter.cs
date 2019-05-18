using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClass
{
	class RhombusAdapter: Rhombus, Shape
	{
		public void draw()
		{
			this.drawShape();
		}
		public void resize()
		{
			Console.WriteLine("Rhombus can't be resized. Please create new one with required values.");
		}
		public string description()
		{
			return "Rhombus object";
		}
		public bool isHide()
		{
			return false;
		}

	}
}
