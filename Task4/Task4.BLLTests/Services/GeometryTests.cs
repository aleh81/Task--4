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
	}
}