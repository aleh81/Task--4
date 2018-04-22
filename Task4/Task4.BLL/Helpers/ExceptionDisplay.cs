using System;

namespace Task4.BLL.Helpers
{
	public static class ExceptionDisplay
	{
		public static void Display(Exception e)
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine(e.GetType());
			Console.WriteLine(e.Message);
			Console.WriteLine();
			Console.ResetColor();
		}
	}
}
