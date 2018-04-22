using System;
using Task4.BLL.Helpers;
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
				Console.WriteLine(triangle);
			}
			catch (Exception e)
			{
				ExceptionDisplay.Display(e);
			}

			try
			{
				var triangle = new Triangle(6.9, 3.9, 4.1);
				Console.WriteLine(triangle);
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
				Console.WriteLine(triangle3);
			}
			catch (Exception e)
			{
				ExceptionDisplay.Display(e);
			}

			try
			{
				var triangle4 = new Triangle(0, -2, 10);
				Console.WriteLine(triangle4);
			}
			catch (Exception e)
			{
				ExceptionDisplay.Display(e);
			}

			if (Triangle.Count != 0)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"Count of triangles: {Triangle.Count}");
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Triangles are not defined");
			}

			Console.ReadKey();
		}
	}
}
