using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4.BLL.Services;

namespace Task4.BLLTests.Services
{
	[TestClass()]
	public class TriangleTests
	{
		[TestMethod()]
		public void ConstructorTestNegativeArguments()
		{
			try
			{
				var tiangle = new Triangle(0, -1, 2);
			}
			catch (ArgumentException e)
			{
				Assert.AreEqual("System.ArgumentException", e.GetType().ToString());
			}

			try
			{
				var trianglePositive = new Triangle(5, 1, 9);
			}
			catch (Exception e)
			{
				Assert.AreEqual(e, null);
			}
		}

		[TestMethod()]
		public void PerimetrTest()
		{
			var tringle1 = new Triangle(9, 5, 7);
			var triangle2 = new Triangle(7.01, 22.657, 34.05);

			Assert.AreEqual(21, tringle1.Perimetr());
			Assert.AreEqual(63.717, triangle2.Perimetr());
		}

		[TestMethod()]
		public void HalfPerimetrTest()
		{
			var triangle1 = new Triangle(4, 8, 6);
			var triangle2 = new Triangle(9.64, 3.002, 5.972);

			Assert.AreEqual(9, triangle1.HalfPerimetr());
			Assert.AreEqual(9.307, triangle2.HalfPerimetr());
		}
	}
}