using System;

namespace AdapterObject
{
	interface IShape
	{
		void draw();
		void resize();
		String description();
		bool isHide();

	}
}
