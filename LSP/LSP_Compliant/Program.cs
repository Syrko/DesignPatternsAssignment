using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Compliant
{
	class Program
	{
		static void Main(string[] args)
		{
			Circle C1 = new Circle();
			Square S1 = new Square();

			Program p = new Program();

			p.DrawShape(C1);
			p.DrawShape(S1);

			Console.Read();
		}

		void DrawShape(Shape shape)
		{
			shape.Draw();
		}
	}

	abstract class Shape
	{
		public abstract void Draw();
	}

	class Circle : Shape
	{
		override public void Draw()
		{
			Console.WriteLine("A circle");
		}
	}

	class Square : Shape
	{
		override public void Draw()
		{
			Console.WriteLine("A square");
		}
	}
}
}
