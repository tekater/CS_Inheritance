using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom
{
	internal class Square : Shape
	{

		public Square(double x, double y) : base(x,y)
		{
			if (x == y)
			{
				Isosceles= true;
			}
		}
		public override double Perimeter()
		{
			if(Isosceles == true)
			{
				return X*4;
			}
			else
			{
				return X+X+Y+Y;
			}
		}
		public override double Area()
		{
			return X * Y;
		}
		public override void Info()
		{
			if(Isosceles == true)
			{
                Console.WriteLine("Квадрат:\n");
			}
			else
			{
                Console.WriteLine("Прямоугольник\n");
            }
			base.Info();
		}


		public override void Print()
		{
			if (X == Y)
			{
				/*for (int i = 0; i <= X; i++)
					{
						for (int j = 0; j <= X; j++)
						{

							if (i == 0 || i == X || j == 0 || j == X)
							{
								Console.Write(" @");
							}
							else
							{

								Console.Write("  ");
							}

						}
						Console.Write("\n");
					}

					Console.Write("\n");
					*/

				for (int i = 0; i <= X - 1; i++)
				{
					for (int j = 0; j <= Y - 1; j++)
					{
						Console.Write(" @");
					}
					Console.Write("\n");
				}

				Console.Write("\n");
			}
			else
			{
				/*
				for (int i = 0; i <= X; i++)
				{
					for (int j = 0; j <= Y; j++)
					{
						if (i == 0 || i == X || j == 0 || j == Y)
						{
                            Console.Write(" #");
						}
						else
						{
							Console.Write("  ");
						}
					}
					Console.Write("\n");
				}
				Console.Write("\n");
				*/
				for (int i = 0; i <= X - 1; i++)
				{
					for (int j = 0; j <= Y - 1; j++)
					{
						Console.Write(" #");
					}
					Console.Write("\n");
				}
			}
		}
	}
}
