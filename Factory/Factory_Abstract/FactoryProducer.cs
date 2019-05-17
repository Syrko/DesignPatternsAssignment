using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Abstract
{
	class FactoryProducer
	{
		public static AbstractFactory getFactory(bool isRoundedFactory)
		{
			if (isRoundedFactory)
			{
				return new RoundedShapeFactory();
			}
			else
			{
				return new ShapeFactory();
			}
		}
	}
}
