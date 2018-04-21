using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4.BLL.Services;

namespace Task4.BLLTests.Services
{
	[TestClass()]
	public class TriangleTests
	{
		[TestMethod()]
		public void ConstructorTestNegativeArgumentsTest()
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
				var tiangle = new Triangle(9, 1, 2);
			}
			catch (ArgumentException e)
			{
				Assert.AreEqual("System.ArgumentException", e.GetType().ToString());
			}


			try
			{
				var triangle2 = new Triangle(9.64, 3.2, 5.972);
			}
			catch (ArgumentException e)
			{
				Assert.AreEqual("System.ArgumentException", e.GetType().ToString());
			}

			try
			{
				var trianglePositive = new Triangle(5, 7, 9);
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

			Assert.AreEqual(21, tringle1.Perimetr);
		}

		[TestMethod()]
		public void AreaTest()
		{
			var triangle1 = new Triangle(4, 5, 3);

			Assert.AreEqual(6, triangle1.Area());
		}

		[TestMethod()]
		public void ExsistTest()
		{
			var triangle1 = new Triangle(4, 5, 3);

			Assert.AreEqual(true, triangle1.Exsist);

			var triangle2 = new Triangle();

			Assert.AreEqual(false, triangle2.Exsist);
		}
	}
}