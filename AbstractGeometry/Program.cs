using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	class Program
	{
		static void Main(string[] args)
		{
			//Shape shape = new Shape();
			IntPtr hwnd = GetConsoleWindow();
			System.Drawing.Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);

			int action;
			do
			{
				Console.WriteLine
					(
					$"[1] - Rectangle\n" +
					$"[2] - Square\n" +
					$"[3] - Triangle\n" +
					$"[4] - Circle\n"
					);
                action = Convert.ToInt32(Console.ReadLine());
				
				switch (action)
				{
					case 1:
						Console.Clear();
						Rectangle rect = new Rectangle(200, 150, 200, 200, 5, Color.Green);
						rect.Info(e);
						break;
					case 2:
						Console.Clear();
						Square square = new Square(200, 200, 200, 5, Color.Green);
						square.Info(e);
						break;
					case 3:
						Console.Clear();
						Triangle triangle = new Triangle(200, 150, 200, 200, 5, Color.Green);
						triangle.Info(e);
						break;
					case 4:
						Console.Clear();
						Circle circle = new Circle(25,200,200,5,Color.Green);
						circle.Info(e);
						break;
					default:
						action = 9;
                        Console.WriteLine("Exit :D\n");
                        break;
				}
			} while (action != 9);

		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
