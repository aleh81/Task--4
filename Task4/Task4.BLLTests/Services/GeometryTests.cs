using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4.BLL.Services;

namespace Task4.BLLTests.Services
{
	[TestClass()]
	public class GeometryTests
	{
		[TestMethod()]
		public void PowTest()
		{
			var triangle1 = new Triangle(4, 5, 3);
			var trianglePow = Geometry.Pow(6, 2);

			Assert.AreEqual(36, trianglePow);
		}

		[TestMethod()]
		public void SqrtTest()
		{
			var sqrt = Geometry.Sqrt(36);

			Assert.AreEqual(6, sqrt);
		}


		[TestMethod()]
		public void LessOrEqualToZeroTest()
		{
			Assert.AreEqual(true, Geometry.LessOrEqualToZero(0, 2, 1));
			Assert.AreEqual(false, Geometry.LessOrEqualToZero(1, 2, 1));
		}

		[TestMethod()]
		public void CorrectnessSidesOfTriangleTest()
		{
			Assert.AreEqual(true, Geometry.CorrectnessSidesOfTriangle(99, 2, 1));
			Assert.AreEqual(false, Geometry.CorrectnessSidesOfTriangle(1, 2, 1));
		}
	}
}