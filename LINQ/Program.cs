
using LINQ.DataSources;

namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Q1

			var seafoodProducts = Source.ProductList.Where(p => p.Category == "Seafood");

			foreach (var product in seafoodProducts)
			{
				Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice:c}");
			}

			#endregion


		}
	}
}
