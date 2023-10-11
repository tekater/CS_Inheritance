using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Triangle:Shape
	{
		double side_a;
		double side_b;
		public double SideA
		{
			get { return side_a; }
			set
			{
				if (value < MIN_SIZE)
				{
					value = MIN_SIZE;
				}
				if (value > MAX_SIZE)
				{
					value = MAX_SIZE;
				}
				side_a = value;
			}
		}

		public double SideB
		{
			get { return side_b; }
			set
			{
				if (value < MIN_SIZE)
				{
					value = MIN_SIZE;
				}
				if (value > MAX_SIZE)
				{
					value = MAX_SIZE;
				}
				side_b = value;
			}
		}

		public Triangle
			(
			double side_a, double side_b,
			int start_x, int start_y, int line_width,
			Color color
			) : base(start_x, start_y, line_width, color)
		{
			SideA = side_a;
			SideB = side_b;
		}

		public override double GetArea()
		{
			return SideA * SideA;
		}

		public override double GetPerimeter()
		{
			return SideA * 4;
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);

			e.Graphics.DrawPolygon(pen,
				/*new PointF[]
				{
					new PointF((float)SideA -20, (float)SideB +10),
					new PointF((float)SideA -10, (float) SideB - 40),
					new PointF((float)SideA + 70, (float) SideB - 20)
				}*/
				/*new Point[]
				{ 
					new Point(StartX, StartY),
					new Point(StartX, StartY + (int)SideB),
					new Point((int)(StartX+SideA), StartX)
				}*/
				new Point[]
				{ 
					new Point(StartX, (int)(StartY + SideB)),
					new Point((int)(StartX+SideA), StartY + (int)SideB),
					new Point((StartX), StartY)
				}

				);
		}
	}
}
