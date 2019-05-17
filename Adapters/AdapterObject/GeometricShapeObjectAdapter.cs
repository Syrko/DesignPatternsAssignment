using System;

namespace AdapterObject
{
	class GeometricShapeObjectAdapter : IShape
	{
		private IGeometricShape adaptee;

		public GeometricShapeObjectAdapter(IGeometricShape adaptee)
		{
			this.adaptee = adaptee;
		}

		public string description()
		{
			return adaptee.GetType().ToString() + " object ";
		}

		public void draw()
		{
			adaptee.drawShape();
		}

		public bool isHide()
		{
			return false;
		}

		public void resize()
		{
			Console.WriteLine(description() + "can't be resized!");
		}
	}
}
