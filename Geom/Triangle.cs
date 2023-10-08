using Geom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;


namespace Geom
{
	internal class Triangle : Shape
	{

		public double H { get; set; }
		public double G { get; set; }
		public Triangle(double x, double y) : base(x, y)
		{
			if (x == y)
			{
				Isosceles = true;
			}
			G = Math.Sqrt(Convert.ToDouble((X*X)+(Y*Y)));
			H = X * Y / G;
		}
		public override double Perimeter()
		{
			if (Isosceles == true)
			{
				return X + (2 * Y);
			}
			else
			{
				return X + Y + H;
			}

		}
		public override double Area()
		{
			return (0.5 * X) * H;
		}
		public override void Info()
		{
			if (Isosceles == true)
			{
				Console.WriteLine("Равнобедренный треугольник\n");
			}
			else
			{
				Console.WriteLine("Прямоугольный треугольник\n");
			}
			base.Info();
            Console.WriteLine
				($"G = {Math.Round(G,2)}\n"+
				$"H = {Math.Round(H,2)}\n"
				);
        }
		public override void Print()
		{
			if (Isosceles == false)
			{
				if(X < Y) { X = Y; }
				/*for (int i = 0; i <= X; i++)
				{
					for (int j = 0; j <= X; j++)
					{
						if (i == j || j == 0 || i == X)
						{
                            Console.Write($"*");
						}
						else
						{
							Console.Write($" ");
						}
					}
					Console.Write($"\n");
				}
				*/
				for (int i = 0; i <= X; i++)
				{
					for (int j = 0; j <= Y; j++)
					{
						if (i > j)
						{
							Console.Write($"*");
						}
						else
						{
							Console.Write($" ");
						}
					}
					Console.Write($"\n");
				}


			}
			else
			{
				// Равнобедренный Треугольник
				/*
				for (int i = 0; i <= X; i++)
				{
					for (int j = 0; j <= X; j++)
					{
						if ((i == j || i + j == X - 1 || i == X - 1) && i >= X / 2)
							Console.Write($" *");
						else
							Console.Write($" ");
					}
					Console.Write($"\n");
				}

				Console.Write($"\n");*/

				for (int i = 0; i <= X; i++)
				{
					for (int j = 0; j <= Y; j++)
					{
						if (i >= j && i + j >= X)
						{
							Console.Write($"*");
						}
						else
						{
							Console.Write($" ");
						}
					}
					Console.Write($"\n");
				}
			}
		}
	}
}