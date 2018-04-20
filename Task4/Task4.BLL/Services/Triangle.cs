using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task4.BLL.Services
{
	public class Triangle
	{
		private const string ExMessage = "Error: The sides of a triangle can not be <= 0";
		private readonly double _a;
		private readonly double _b;
		private readonly double _c;

		public Triangle(double a, double b, double c)
		{
			if ((a <= 0) || (b <= 0) || (c <=0))
			{
				throw new ArgumentException(ExMessage);
			}
			else
			{
				this._a = a;
				this._b = b;
				this._c = c;
			}
		}

		public double Perimetr() => _a + _b + _c;

		public double HalfPerimetr() => Perimetr() / 2;

	}
}
