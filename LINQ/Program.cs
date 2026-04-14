
using LINQ.DataSources;

namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Q1

			//var seafoodProducts = Source.ProductList.Where(p => p.Category == "Seafood");

			//foreach (var product in seafoodProducts)
			//{
			//	Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice:c}");
			//}

			#endregion

			#region Q2

			//var productNames = Source.ProductList.Select(p => p.ProductName);

			//foreach (var name in productNames)
			//{
			//	Console.WriteLine($"Name: {name}");
			//}

			#endregion

			#region Q3

			var sortedProducts = Source.ProductList.OrderBy(p => p.UnitPrice);

			foreach (var p in sortedProducts)
			{
				Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice:c}");
			}

			#endregion

			#region Q4

			var midRangeProducts = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

			foreach (var p in midRangeProducts)
			{
				
				Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice:c}");

			}

			#endregion


		}
	}
}
