using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom
{
	internal class Program
	{
		public static readonly string delimeter = "\n--------------------------------------\n";
		static void Main(string[] args)
		{
			Square square = new Square(5, 6);
			square.Info();
			square.Print();

			Console.WriteLine(delimeter);

            Square square2 = new Square(10, 10);
			square2.Info();
			square2.Print();



			Console.WriteLine(delimeter);
            Console.WriteLine("\n");
            Console.WriteLine(delimeter);



			Triangle triangle = new Triangle(5, 10);
			triangle.Info();
			triangle.Print();

			Console.WriteLine(delimeter);

			Triangle triangle2 = new Triangle(10, 10);
			triangle2.Info();
			triangle2.Print();
		}
	}
}
