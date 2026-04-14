
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

			//var sortedProducts = Source.ProductList.OrderBy(p => p.UnitPrice);

			//foreach (var p in sortedProducts)
			//{
			//	Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice:c}");
			//}

			#endregion

			#region Q4

			//var midRangeProducts = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

			//foreach (var p in midRangeProducts)
			//{

			//	Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice:c}");

			//}

			#endregion

			#region Q5

			//var availableCondiments = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

			//foreach (var p in availableCondiments)
			//{
			//	Console.WriteLine($"Name: {p.ProductName} Stock: {p.UnitsInStock}");
			//}

			#endregion

			#region Q6

			//var productStatuses = Source.ProductList.Select(p => new
			//{
			//	Name = p.ProductName,
			//	Price = p.UnitPrice,
			//	StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
			//});

			//foreach (var item in productStatuses)
			//{
			//	Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Status: {item.StockStatus}");
			//}

			#endregion

			#region Q7

			//var productsWithIndex = Source.ProductList.Select((p, index) => new { Index = index + 1, Name = p.ProductName });

			//foreach (var item in productsWithIndex)
			//{
			//	Console.WriteLine($"{item.Index}. {item.Name}");
			//}

			#endregion

			#region Q8

			//var multiSortedProducts = Source.ProductList.OrderBy(p => p.Category)
			//						 .ThenByDescending(p => p.UnitPrice);

			//foreach (var p in multiSortedProducts) { 
			//	Console.WriteLine($"Name: {p.ProductName}, Category: {p.Category}, Price: {p.UnitPrice:c}");
			//}

			#endregion

			#region Q9

			//var beverages = Source.ProductList.Where(p => p.Category == "Beverages")
			//			   .OrderByDescending(p => p.UnitsInStock);

			//foreach (var b in beverages)
			//{
			//	Console.WriteLine($"Name: {b.ProductName}, Stock: {b.UnitsInStock}");
			//}

			#endregion

			#region Q10

			//var orders97 = from c in Source.CustomerList
			//			   from o in c.Orders 
			//			   where o.OrderDate.Year >= 1997
			//			   select new { c.CustomerID, o.OrderDate };

			//foreach (var o in orders97)
			//{

			//	Console.WriteLine( o.CustomerID);	

			//	Console.WriteLine( o.OrderDate.ToShortDateString());
			//}

			#endregion

			#region Q11

			//var productListWithPos = Source.ProductList.Select((p, i) => $"{i + 1}. {p.ProductName}");

			//foreach (var item in productListWithPos)
			//{
			//	Console.WriteLine(item);
			//}

			#endregion

			#region Q12

			String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

			var sortedWords = Arr.OrderBy(w => w.Length)
								 .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

			foreach (var word in sortedWords)
			{
				Console.WriteLine(word);
			}

			#endregion


		}
	}
}
