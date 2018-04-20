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
			var triangle = new Triangle(4.95, 5.244, 3.11);
			var triangle2 = new Triangle();

			if (triangle.Exsist)
			{
				Console.WriteLine($"Sides of triangle: {triangle}");
				Console.WriteLine(triangle.GetPerimetr);
				Console.WriteLine(triangle.GetArea);
			}
			else
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.WriteLine("Triangle is not defined");
			}

			if (triangle2.Exsist)
			{
				Console.WriteLine(triangle2);
			}
			else
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.WriteLine("Triangle is not defined");
			}
			Console.ReadKey();
		}
	}
}
