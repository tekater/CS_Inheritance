using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom
{

	internal class Shape
	{

		public double X { get; set; }
		public double Y { get; set; }
		public bool Isosceles { get; set; }
		public Shape(double x, double y)
		{
			X = x;
			Y = y;
			Isosceles = false;
		}
		public virtual double Perimeter()
		{
			return X + Y;

		}
		public virtual double Area()
		{
			return X * Y;
		}
		public virtual void Info()
		{
            Console.WriteLine
				(
				$"X = {X}\n" +
				$"Y = {Y}\n" +
				$"Isosceles = {Isosceles}\n" +
				$"Area = {Math.Round(Area(),2)}\n" +
				$"Perimeter = {Math.Round(Perimeter(),2)}"
				);
        }
		public virtual void Print()
		{
            Console.WriteLine("-");
        }
		
	}
}