using System;

namespace Task4.BLL.Services
{
	public class Triangle
	{
		public double? A { get; private set; }
		public double? B { get; private set; }
		public double? C { get; private set; }

		private const string ExeptionTriangleExsist = "ERROR: Triangle is not defined";
		private const string ExeptionWrongArguments = "ERROR: The sides of triangle cannot be <= 0";
		private const string ExeptionLenghtOfSideOfTriangle = "ERROR: One side of the triangle is " +
		                                                      "larger than the sum of other two sides." +
		                                                      "Such triangle cannot be exsist!";

		public Triangle() : this(null, null, null)
		{
		}

		public Triangle(double? a, double? b, double? c)
		{
			if ((a <= 0) || (b <= 0) || (c <= 0))
			{
				throw new ArgumentException(ExeptionWrongArguments);
			}
			else if (a > (b + c) || b > (c + a) || c > (a + b))
			{
				throw new ArgumentException(ExeptionLenghtOfSideOfTriangle);
			}
			else
			{
				A = a;
				B = b;
				C = c;
			}
		}

		private bool Exsist => 
			(A.HasValue) && (B.HasValue) && (C.HasValue);

		public double? Perimetr => Exsist ?
			A + B + C : throw new ArgumentException(ExeptionTriangleExsist);

		public double? HalfPerimetr => Perimetr / 2;

		private static double? Pow(double? a, int pow) => 
			pow != 1 ? a * Pow(a, --pow) : a;

		private static double? Sqrt(double? num, int n = 2, double eps = 0.000001, double? startNum = null)
		{
			if (startNum == null)
			{
				startNum = num;
			}

			var prev = num;
			num = (1.0 / n) * ((n - 1) * num + startNum.Value / (Pow(num, n - 1)));

			if ((prev - num) >= eps)
			{
				return Sqrt(num, n, eps, startNum);
			}
			else
			{
				return num;
			}
		}

		public double? Area()
		{
			var halfPerimetr = HalfPerimetr;

			var p = (halfPerimetr - A) * (halfPerimetr - B) * (halfPerimetr - C);

			var s = halfPerimetr * p;

			return Sqrt(s);
		}

		public override string ToString() => Exsist ?
			$"A ={A: 0.00} cm; B ={B: 0.00} cm; C ={C: 0.00} cm;"
		    : throw new ArgumentException(ExeptionTriangleExsist);

		public string GetPerimetr => Exsist ?
			$"The perimetr of the triangle = {Perimetr: 0.00} cm"
			: throw new ArgumentException(ExeptionTriangleExsist);

		public string GetArea => Exsist ?
			$"The area of the triangle = {Area(): 0.00} cm squared"
		    : throw new ArgumentException(ExeptionTriangleExsist);
	}
}
