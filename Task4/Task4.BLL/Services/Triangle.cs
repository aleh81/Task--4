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
		private double _a;
		private double _b;
		private double _c;

		public Triangle()
		{
			_a = 0;
			_b = 0;
			_c = 0;
		}

		public Triangle(double a, double b, double c)
		{
				_a = Math.Abs(a);
				_b = Math.Abs(b);
				_c = Math.Abs(c);
		}

		public bool Exsist => (!(_a <= 0)) && (!(_b <= 0)) && (!(_c <= 0));

		public double Perimetr => _a + _b + _c;

		public double HalfPerimetr => Perimetr / 2;

		public double Area()
		{
			var halfPerimetr = HalfPerimetr;

			var p = (halfPerimetr - _a) * (halfPerimetr - _b) * (halfPerimetr - _c);

			var s = halfPerimetr * p;

			return Math.Sqrt(s);
		}

		public override string ToString()
		{
			return $"A ={_a: 0.00} cm; B ={_b: 0.00} cm; C ={_c: 0.00} cm;";
		}

		public string GetPerimetr => $"The perimetr of the triangle = {Perimetr: 0.00} cm";

		public string GetArea => $"The area of the triangle = {Area(): 0.00} cm squared";
	}
}
