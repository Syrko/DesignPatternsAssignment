using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Abstract
{
	class RoundedShapeFactory: AbstractFactory
	{
		public override Shape getShape(string type)
		{
			switch (type)
			{
				case ("RECTANGLE"):
					return new RoundedRectangle();
				case ("SQUARE"):
					return new Square();
				default:
					Console.WriteLine("Invalid shape type...");
					return null;
			}
		}
	}
}
