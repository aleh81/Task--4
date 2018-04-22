using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.BLL.Services
{
	public static class ExceptionDisplay
	{
		public static void Display(Exception e)
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine(e.GetType());
			Console.WriteLine(e.Message);
			Console.ResetColor();
		}
	}
}
