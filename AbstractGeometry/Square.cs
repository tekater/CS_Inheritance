using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Square:Rectangle
	{
		public Square(
			double side_a,
			int start_x, int start_y, int line_width,
			Color color
			) : base(side_a, side_a, start_x, start_y, line_width, color)
		{
			SideB = SideA;
		}

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (int)SideA, (int)SideB);
		}
		public override double GetArea()
		{
			return SideA * SideA;
		}

		public override double GetPerimeter()
		{
			return SideA*4;
		}

		public override void Info(PaintEventArgs e)
		{
			base.Info(e);
		}

	}
}
