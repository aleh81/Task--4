using System;
using Task4.BLL.Services.Interfaces;

namespace Task4.BLL.Services
{
	/// <summary>
	/// This class describes the operation of a triangle
	/// </summary>
	public class Triangle: IFigure
	{
		/// <summary>
		/// The first side of the triangle
		/// </summary>
		public double? A { get; private set; }
		/// <summary>
		/// The second side of the triangle
		/// </summary>
		public double? B { get; private set; }
		/// <summary>
		/// The thirt side of the triangle
		/// </summary>
		public double? C { get; private set; }

		/// <summary>
		/// Count of triangles
		/// </summary>
		public static int Count { get; set; }

		private const string ExeptionTriangleExsist = "ERROR: Triangle is not defined";
		private const string ExeptionWrongArguments = "ERROR: The sides of triangle cannot be <= 0";
		private const string ExeptionLenghtOfSideOfTriangle = "ERROR: One side of the triangle is " +
		                                                      "larger than the sum of other two sides." +
		                                                      "Such triangle cannot be exsist!";
		/// <summary>
		/// The constructor does not initialize the sides of the triangle
		/// </summary>
		public Triangle() : this(null, null, null)
		{
		}

		/// <summary>
		/// The сonstructor initializing the sides of the triangle 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		public Triangle(double? a, double? b, double? c)
		{
			if (LessOrEqualToZero(a, b, c))
			{
				throw new ArgumentException(ExeptionWrongArguments);
			}
			else if (CorrectnessSides(a, b, c))
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

		private static bool LessOrEqualToZero(double? a, double? b, double? c) =>
			(a <= 0) || (b <= 0) || (c <= 0);

		private static bool CorrectnessSides(double? a, double? b, double? c) =>
			a > (b + c) || b > (c + a) || c > (a + b);

		/// <summary>
		/// Sum perimetr of two objects
		/// </summary>
		/// <param name="lhs"></param>
		/// <param name="rhs"></param>
		/// <returns></returns>
		public static double? operator +(Triangle lhs, Triangle rhs) =>
			lhs.Perimetr + rhs.Perimetr;

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString() => Exsist ?
			GetSidesToString + '\n' + GetPerimetrToString + '\n' + GetAreaToString + '\n'
			: throw new ArgumentException(ExeptionTriangleExsist);

		private string GetSidesToString => Exsist ?
			$"Sides of triangle: A ={A: 0.00} cm; B ={B: 0.00} cm; C ={C: 0.00} cm;"
			: throw new ArgumentException(ExeptionTriangleExsist);

		/// <summary>
		/// Getting perimetr with string format
		/// </summary>
		public string GetPerimetrToString => Exsist ?
			$"The perimetr of the triangle = {Perimetr: 0.00} cm"
			: throw new ArgumentException(ExeptionTriangleExsist);

		/// <summary>
		/// Getting Area with string format
		/// </summary>
		public string GetAreaToString => Exsist ?
			$"The area of the triangle = {Area(): 0.00} cm squared"
			: throw new ArgumentException(ExeptionTriangleExsist);

		/// <summary>
		/// Getting the area of the triangle
		/// </summary>
		public double? GetArea => Exsist ?
			Area() : throw new ArgumentException(ExeptionTriangleExsist);

		/// <summary>
		/// Getting perimetr of the triangle
		/// </summary>
		public double? GetPerimetr => Exsist ?
			Perimetr : throw new ArgumentException(ExeptionTriangleExsist);
	}
}
