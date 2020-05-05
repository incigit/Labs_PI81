using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._4
{
	class Program
	{
		static void Main()
		{
			double x1 = 0;
			double x2 = 0;

			x1 = Bisection(-2, 0, x1);
			x2 = Bisection(0, 1, x2);


			Console.WriteLine($"x1: {x1}");
			Console.WriteLine($"x2: {x2}");
			Console.ReadKey();
		}

		static double F(double x)
		{
			// Func
			return Math.Pow(x, 4) + (2 * Math.Pow(x, 3)) - x - 1;
		}

		static double Bisection(double min, double max, double x)
		{
			double length = max - min;
			double err = length;
			const double accuracy = 1e-8;

			while (err > accuracy && F(x) != 0)
			{
				x = (min + max) / 2;
				if (F(min) * F(x) < 0)
				{
					max = x;
				}
				else if (F(x) * F(max) < 0)
				{
					min = x;
				}

				err = (max - min) / length;
			}

			return x;
		}
	}
}