using System;
using System.Dynamic;

namespace Task4.BLL.Services
{
	public static class Geometry
	{
		public static double? Pow(double? a, int pow) =>
			pow != 1 ? a * Pow(a, --pow) : a;

		public static double? Sqrt(double? num, int n = 2, double eps = 0.000001, double? startNum = null)
		{
			if (startNum == null)
			{
				startNum = num;
			}

			var prev = num;
			num = (1.0 / n) * ((n - 1) * num + startNum / (Pow(num, n - 1)));

			return (prev - num) >= eps ? Sqrt(num, n, eps, startNum) : num;
		}

		public static bool LessOrEqualToZero(double? a, double? b, double? c) =>
			(a <= 0) || (b <= 0) || (c <= 0);

		public static bool CorrectnessSidesOfTriangle(double? a, double? b, double? c) =>
			a > (b + c) || b > (c + a) || c > (a + b);
	}
}
