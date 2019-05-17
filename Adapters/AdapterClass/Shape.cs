using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClass
{
	interface Shape
	{
		void draw();
		void resize();
		string description();
		bool isHide();

	}
}
