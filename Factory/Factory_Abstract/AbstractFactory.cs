using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Abstract
{
	abstract class AbstractFactory
	{
		public abstract Shape getShape(string type);
	}
}
