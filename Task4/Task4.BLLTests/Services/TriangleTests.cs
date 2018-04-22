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
			var triangle = new Triangle(3, 5, 7);

			Assert.AreEqual(15, triangle.GetPerimetr);
		}

		[TestMethod()]
		public void AreaTest()
		{
			var triangle = new Triangle(3, 5, 7);

			Assert.AreEqual(6.49519052838329, triangle.GetArea);
		}
	}
}