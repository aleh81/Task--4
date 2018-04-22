namespace Task4.BLL.Services.Interfaces
{
	internal interface IFigure
	{
		double? GetArea { get; }
		double? GetPerimetr { get; }
		string GetAreaToString { get; }
		string GetPerimetrToString { get; }
	}
}
