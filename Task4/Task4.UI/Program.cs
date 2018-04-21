using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
				Console.WriteLine(triangle.GetPerimetr);
				Console.WriteLine(triangle.GetArea);
			}
			catch (Exception e)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.WriteLine(e.GetType());
				Console.WriteLine(e.Message);
				Console.ResetColor();
			}

			try
			{
				var triangle2 = new Triangle();
				Console.WriteLine(triangle2);
			}
			catch (Exception e)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.WriteLine(e.GetType()); 
				Console.WriteLine(e.Message);
				Console.ResetColor();
			}

			try
			{
				var triangle3 = new Triangle(9.64, 3.2, 5.972);
			}
			catch (Exception e)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.WriteLine(e.GetType());
				Console.WriteLine(e.Message);
				Console.ResetColor();
			}

			try
			{
				var triangle4 = new Triangle(0, -2, 10);
			}
			catch (Exception e)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.WriteLine(e.GetType());
				Console.WriteLine(e.Message);
				Console.ResetColor();
			}

			Console.ReadKey();
		}
	}
}
