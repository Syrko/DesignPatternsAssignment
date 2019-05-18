using System;

namespace LSP_Violation
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
			if(shape.GetType() == typeof(Circle))
			{
				((Circle)shape).Draw();
			}
			else if (shape.GetType() == typeof(Square))
			{
				((Square)shape).Draw();
			}
		}
	}

	abstract class Shape
	{

	}
	
	class Circle: Shape
	{
		public void Draw()
		{
			Console.WriteLine("A circle");
		}
	}

	class Square : Shape
	{
		public void Draw()
		{
			Console.WriteLine("A square");
		}
	}
}
