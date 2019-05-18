using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Abstract
{
	class RoundedRectangle: Shape
	{
		public void draw()
		{
			Console.WriteLine("Drawing " + this.GetType().Name);
		}
	}
}
