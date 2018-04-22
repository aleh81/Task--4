using System;
using Task4.BLL.Services;

namespace Task4.UI
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var triangle = new Triangle(4.95, 5.244, 3.11);
				Console.WriteLine($"Sides of triangle: {triangle}");
				Console.WriteLine(triangle.GetPerimetrToString);
				Console.WriteLine(triangle.GetAreaToString);
			}
			catch (Exception e)
			{
				ExceptionDisplay.Display(e);
			}

			try
			{
				var triangle2 = new Triangle();
				Console.WriteLine(triangle2);
			}
			catch (Exception e)
			{
				ExceptionDisplay.Display(e);
			}

			try
			{
				var triangle3 = new Triangle(9.64, 3.2, 5.972);
			}
			catch (Exception e)
			{
				ExceptionDisplay.Display(e);
			}

			try
			{
				var triangle4 = new Triangle(0, -2, 10);
			}
			catch (Exception e)
			{
				ExceptionDisplay.Display(e);
			}

			Console.ReadKey();
		}
	}
}
