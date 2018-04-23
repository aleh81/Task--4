using System;
using Task4.BLL.Services.Interfaces;

namespace Task4.BLL.Services
{
	public class Triangle: IFigure
	{
		public double? A { get; private set; }
		public double? B { get; private set; }
		public double? C { get; private set; }

		public static int Count { get; set; }

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
			if (Geometry.LessOrEqualToZero(a, b, c))
			{
				throw new ArgumentException(ExeptionWrongArguments);
			}
			else if (Geometry.CorrectnessSidesOfTriangle(a, b, c))
			{
				throw new ArgumentException(ExeptionLenghtOfSideOfTriangle);
			}
			else
			{
				A = a;
				B = b;
				C = c;

				if (Exsist)
				{
					Count++;
				}
			}
		}

		private bool Exsist =>
			(A.HasValue) && (B.HasValue) && (C.HasValue);

		private double? Perimetr => Exsist ?
			A + B + C : throw new ArgumentException(ExeptionTriangleExsist);

		private double? HalfPerimetr => Perimetr / 2;

		private double? Area()
		{
			var halfPerimetr = HalfPerimetr;

			var p = (halfPerimetr - A) * (halfPerimetr - B) * (halfPerimetr - C);

			var s = halfPerimetr * p;

			return Geometry.Sqrt(s);
		}

		public static double? operator +(Triangle lhs, Triangle rhs) =>
			lhs.Perimetr + rhs.Perimetr;

		public override string ToString() => Exsist ?
			GetSidesToString + '\n' + GetPerimetrToString + '\n' + GetAreaToString + '\n'
			: throw new ArgumentException(ExeptionTriangleExsist);

		private string GetSidesToString => Exsist ?
			$"Sides of triangle: A ={A: 0.00} cm; B ={B: 0.00} cm; C ={C: 0.00} cm;"
			: throw new ArgumentException(ExeptionTriangleExsist);

		public string GetPerimetrToString => Exsist ?
			$"The perimetr of the triangle = {Perimetr: 0.00} cm"
			: throw new ArgumentException(ExeptionTriangleExsist);

		public string GetAreaToString => Exsist ?
			$"The area of the triangle = {Area(): 0.00} cm squared"
			: throw new ArgumentException(ExeptionTriangleExsist);

		public double? GetArea => Exsist ?
			Area() : throw new ArgumentException(ExeptionTriangleExsist);

		public double? GetPerimetr => Exsist ?
			Perimetr : throw new ArgumentException(ExeptionTriangleExsist);
	}
}
